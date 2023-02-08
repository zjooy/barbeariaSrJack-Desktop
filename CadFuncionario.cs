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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void CarregarDadosFuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionario` WHERE idFuncionario=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeFuncionario = dr.GetString(1);
                    variaveis.emailFuncionario = dr.GetString(2);
                    variaveis.senhaFuncionario = dr.GetString(3);
                    variaveis.statusFuncionario = dr.GetString(4);
                    variaveis.nivelFuncionario = dr.GetString(5);
                    variaveis.dataCadFuncionario = dr.GetDateTime(6);
                    variaveis.horarioTrabalhoFuncionario = DateTime.Parse(dr.GetString(7));


                    txtCodigo.Text = variaveis.codFuncionario.ToString();
                    txtNomeFuncionario.Text = variaveis.nomeFuncionario;
                    txtEmail.Text = variaveis.emailCliente;
                    txtSenha.Text = variaveis.senhaCliente;
                    cmbStatus.Text = variaveis.statusFuncionario;
                    cmbNivel.Text = variaveis.nivelFuncionario;
                    mkdDataDeCadastro.Text = variaveis.dataCadFuncionario.ToString("dd/MM/yyyy");
                    cmbCargaHoraria.Text = variaveis.horarioTrabalhoFuncionario.ToString("HH:mm");
                    banco.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Funcionário! \n\n" + ex);
            }
        }

        private void InserirFuncionario()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `funcionaria`(`idFuncionario`, `nomeFuncionario`, `emailFuncionario`, `senhaFuncionario`, `statusFuncionario`,`nivelFuncionario`,`horarioTrabalhoFuncionario`, `dataCadFuncionario`) VALUES (DEFAULT,@nomeFuncionario,@emailFuncionario,@senhaFuncionario,@statusFuncionario,@nivelFuncionario,@horarioTrabalhoFuncionario,@dataCadFuncionario)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeFuncionario", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@emailFuncionario", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senhaFuncionario", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@statusFuncionario", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@nivelFuncionario", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@horarioTrabalhoFuncionario", variaveis.horarioTrabalhoFuncionario.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@dataCadFuncionario", variaveis.dataCadFuncionario.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DO FUNCIONÁRIO REALIZADO COM SUCESSO!!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR O FUNCIONÁRIO. \n\n" + ex);
            }
        }

        private void AlterarFuncionario()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `funcionario` SET `nomeFuncionario`=@nomeFuncionario,`emailFuncionario`=@emailFuncionario,`senhaFuncionario`=@senhaFuncionario,`statusFuncionario`=@statusFuncionario,`nivelFuncionario`=@nivelFuncionario, `horarioTrabalhoFuncionario`=@horarioTrabalhoFuncionario WHERE idFuncionario=@codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@nomeFuncionario", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@emailFuncionario", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senhaFuncionario", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@statusFuncionario", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@nivelFuncionario", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@horarioTrabalhoFuncionario", variaveis.horarioTrabalhoFuncionario.ToString("HH:mm"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DO FUNCIONÁRIO REALIZADA COM SUCESSO!!", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ALTERAR O FUNCIONÁRIO. \n\n" + ex);
            }
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Hide();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            pnlCadFuncionario.Location = new Point(this.Width / 2 - pnlCadFuncionario.Width / 2, this.Height / 2 - pnlCadFuncionario.Height / 2);

            if (variaveis.funcao == "ALTERAR")
            {
                CarregarDadosFuncionario();
                lblCadastrarFuncionario.Text = "ALTERAR EMPRESA";
            }

            if (txtCodigo.Text != "")
            {
                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = true;
                txtEmail.Enabled = true;
                cmbStatus.Enabled = true;
                cmbCargaHoraria.Enabled = true;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeFuncionario.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome!");
                txtNomeFuncionario.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o email!");
                txtEmail.Focus();
            }
            else if (txtSenha.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher a senha!");
                txtEmail.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status!");
                cmbStatus.Focus();
            }
            else if (cmbNivel.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o nivel!");
                cmbNivel.Focus();
            }
            else if (cmbCargaHoraria.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar a carga horária!");
                cmbCargaHoraria.Focus();
            }
            else
            {
                variaveis.nomeFuncionario = txtNomeFuncionario.Text;
                variaveis.emailFuncionario = txtEmail.Text;
                variaveis.senhaFuncionario = txtSenha.Text;
                variaveis.statusFuncionario = cmbStatus.Text;
                variaveis.nivelFuncionario = cmbNivel.Text;
                if (variaveis.funcao == "CADASTRAR")
                {
                    mkdDataDeCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    variaveis.dataCadEmpresa = DateTime.Parse(mkdDataDeCadastro.Text);
                }
                variaveis.horarioAtendEmpresa = DateTime.Parse(cmbCargaHoraria.Text);

                if (variaveis.funcao == "CADASTRAR")
                {
                    InserirFuncionario();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    AlterarFuncionario();
                }

                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        

     
    }
}
