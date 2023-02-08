using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbeariaSrJack
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void CarregarDadosCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `cliente` WHERE idCliente=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codCliente);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeCliente = dr.GetString(1);
                    variaveis.emailCliente = dr.GetString(2);
                    variaveis.senhaCliente = dr.GetString(3);
                    variaveis.statusCliente = dr.GetString(4);
                    variaveis.dataCadCliente = dr.GetDateTime(5);

                    txtCodigo.Text = variaveis.codCliente.ToString();
                    txtNomeCliente.Text = variaveis.nomeCliente;                   
                    txtEmail.Text = variaveis.emailCliente;
                    txtSenha.Text = variaveis.senhaCliente;
                    cmbStatus.Text = variaveis.statusCliente;
                    mkdDataDeCadastro.Text = variaveis.dataCadCliente.ToString("dd/MM/yyyy");
                    banco.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da Empresa! \n\n" + ex);
            }
        }

        private void InserirCliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `cliente`(`idCliente`, `nomeCliente`, `emailCliente`, `senhaCliente`, `statusCliente`, `dataCadCliente`) VALUES (DEFAULT,@nomeCliente,@emailCliente,@senhaCliente,@statusCliente,@dataCadCliente)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeCliente", variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@dataCadCliente", variaveis.dataCadCliente.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DO CLIENTE REALIZADO COM SUCESSO!!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR O CLIENTE. \n\n" + ex);
            }
        }

        private void AlterarCliente()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `cliente` SET `nomeCliente`=@nomeCliente,`emailCliente`=@emailCliente,`senhaCliente`=@senhaCliente,`statusCliente`=@statusCliente WHERE idCliente=@codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codCliente);
                cmd.Parameters.AddWithValue("@nomeCliente", variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DO CLIENTE REALIZADO COM SUCESSO!!", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ALTERAR O CLIENTE. \n\n" + ex);
            }
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Hide();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);

            if (variaveis.funcao == "ALTERAR")
            {
                CarregarDadosCliente();
                lblCadastrarCliente.Text = "ALTERAR CLIENTE";
            }

            if (txtCodigo.Text != "")
            {
                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = true;
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                cmbStatus.Enabled = true;
                btnFoto.Enabled = true;
            }


         
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome do Cliente!");
                txtNomeCliente.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o email do Cliente!");
                txtEmail.Focus();
            }
            else if (txtSenha.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher a senha!");
                txtSenha.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status do Cliente!");
                cmbStatus.Focus();
            }
            else
            {
                variaveis.nomeCliente = txtNomeCliente.Text;
                variaveis.emailCliente = txtEmail.Text;
                variaveis.senhaCliente = txtSenha.Text;
                variaveis.statusCliente = cmbStatus.Text;
                if (variaveis.funcao == "CADASTRAR")
                {
                    mkdDataDeCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    variaveis.dataCadCliente = DateTime.Parse(mkdDataDeCadastro.Text);
                }
                if (variaveis.funcao == "CADASTRAR")
                {
                    InserirCliente();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    AlterarCliente();
                }

                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;

            }
        }
    }
}
