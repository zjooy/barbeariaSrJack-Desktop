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
                MessageBox.Show("Erro ao carregar dados do cliente! \n\n" + ex);
            }
        }

        private void InserirCliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `cliente`(`idCliente`, `nomeCliente`, `emailCliente`, `senhaCliente`, `statusCliente`, `dataCadCliente`,`usuariotp`) VALUES (DEFAULT,@nomeCliente,@emailCliente,@senhaCliente,@statusCliente,@dataCadCliente,@usuariotp)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeCliente", variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@dataCadCliente", variaveis.dataCadCliente.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@usuariotp", variaveis.usuariotp);
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

        //telefone
        public void InserirFoneCliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `fonecliente`(`idFoneCliente`, `numeroCliente`, `operFoneCliente`, `descFoneCliente`, `idCliente`) VALUES (DEFAULT,@numeroFone,@operFone,@descFone,@codCliente)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneCliente);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraCliente);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoCliente);
                cmd.Parameters.AddWithValue("@codCliente", variaveis.codCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DO CLIENTE CADASTRADO COM SUCESSO!!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR TELEFONE DO CLIENTE. \n\n" + ex);
            }
        }

        public void CarregarUltimoCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT MAX(idCliente) FROM `cliente`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.codCliente = dr.GetInt32(0);
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar último cliente \n\n" + ex);
            }
        }

        public void AlterarFoneCliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `fonecliente` `numeroCliente`=@numeroFone, `operFoneCliente`=@operFone, `descFoneCliente`=@descFone  WHERE `idFoneCliente`=@codigo";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneCliente);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraCliente);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoCliente);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFoneCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DO CLIENTE ATUALIZADO COM SUCESSO!!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ATUALIZAR O TELEFONE DO CLIENTE. \n\n" + ex);
            }
        }

        public void CarregarTelefones()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM fonecliente WHERE `idCliente`=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTelefone.DataSource = dt;
                dgvTelefone.Columns[0].Visible = false;
                dgvTelefone.Columns[1].HeaderText = "NÚMERO";
                dgvTelefone.Columns[2].HeaderText = "OPERADORA";
                dgvTelefone.Columns[3].HeaderText = "DESCRICAO";
                dgvTelefone.Columns[4].Visible = false;

                dgvTelefone.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR TELEFONES \n\n" + ex);
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
            else if (cmbNivel.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o Nivel do Cliente!");
                cmbNivel.Focus();
            }
            else
            {
                variaveis.nomeCliente = txtNomeCliente.Text;
                variaveis.emailCliente = txtEmail.Text;
                variaveis.senhaCliente = txtSenha.Text;
                variaveis.statusCliente = cmbStatus.Text;
                if (cmbNivel.Text == "Outros")
                {
                    variaveis.usuariotp = 2;
                }
                else if (cmbNivel.Text == "Administrador")
                {
                    variaveis.usuariotp = 1;
                }
                if (variaveis.funcao == "CADASTRAR")
                {
                    mkdDataDeCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    variaveis.dataCadCliente = DateTime.Parse(mkdDataDeCadastro.Text);
                }
                if (variaveis.funcao == "CADASTRAR")
                {
                    InserirCliente();
                    CarregarUltimoCliente();
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

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Enabled = true;
                txtEmail.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Enabled = true;
                cmbStatus.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Enabled = true;
                txtSenha.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbNivel.Enabled = true;
            cmbNivel.Focus();
            
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR FONE";
            pnlCadFone.Visible = true;
            pnlCadFone.Location = new Point(this.Width / 2 - pnlCadFone.Width / 2, this.Height / 2 - pnlCadFone.Height / 2);
            pnlCadCliente.Enabled = false;
            mkdCadTelefone.Focus();
        }

        private void btnFecharFone_Click(object sender, EventArgs e)
        {
            pnlCadCliente.Enabled = true;
            CarregarTelefones();
            pnlCadFone.Visible = false;
            pnlCadFone.Location = new Point(this.Width / 2 - pnlCadFone.Width / 2, this.Height / 2 - pnlCadFone.Height / 2);
        }

        private void mkdCadTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbOperadora.Enabled = true;
                cmbOperadora.Focus();
            }
        }

        private void cmbOperadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDescricao.Enabled = true;
                txtDescricao.Focus();
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lblSalvarFone.Enabled = true;
                lblSalvarFone.Focus();
            }
        }

        private void lblSalvarFone_Click(object sender, EventArgs e)
        {
            if (mkdCadTelefone.MaskCompleted == false)
            {
                MessageBox.Show("Preencher o telefone");
                mkdCadTelefone.Focus();
            }
            else if (cmbOperadora.Text == "")
            {
                MessageBox.Show("Preencher a operadora");
                cmbOperadora.Focus();
            }
            else if (txtDescricao.Text == "")
            {
                MessageBox.Show("Preencher a Descrição");
                txtDescricao.Focus();
            }
            else
            {
                variaveis.numeroFoneCliente = mkdCadTelefone.Text;
                variaveis.operadoraCliente = cmbOperadora.Text;
                variaveis.descricaoCliente = txtDescricao.Text;

                if (variaveis.funcao == "CADASTRAR FONE")
                {
                    InserirFoneCliente();
                }
                else if (variaveis.funcao == "ALTERAR FONE")
                {
                    AlterarFoneCliente();
                }
            }
            //lblLimparFone.PerformClick();

        }

        private void lblLimparFone_Click(object sender, EventArgs e)
        {
            mkdCadTelefone.Text = String.Empty;
            cmbOperadora.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            cmbOperadora.Enabled = false;
            txtDescricao.Enabled = false;
            lblSalvarFone.Enabled = false;
            mkdCadTelefone.Focus();
        }

        private void dgvTelefone_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            variaveis.linhaSelecionada = -1;
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codFoneCliente = Convert.ToInt32(dgvTelefone[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void cmbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnSalvar.Enabled = true;
            btnSalvar.Focus();
        }

        
    }
}
