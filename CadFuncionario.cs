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
                    txtEmail.Text = variaveis.emailFuncionario;
                    txtSenha.Text = variaveis.senhaFuncionario;
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
                string inserir = "INSERT INTO `funcionario`(`idFuncionario`, `nomeFuncionario`, `emailFuncionario`, `senhaFuncionario`, `statusFuncionario`,`nivelFuncionario`,`horarioTrabalhoFuncionario`, `dataCadFuncionario`,`idEmpresa`) VALUES (DEFAULT,@nomeFuncionario,@emailFuncionario,@senhaFuncionario,@statusFuncionario,@nivelFuncionario,@horarioTrabalhoFuncionario,@dataCadFuncionario,@empresaFunc)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeFuncionario", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@emailFuncionario", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senhaFuncionario", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@statusFuncionario", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@nivelFuncionario", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@horarioTrabalhoFuncionario", variaveis.horarioTrabalhoFuncionario.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@dataCadFuncionario", variaveis.dataCadFuncionario.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@empresaFunc)", variaveis.idEmpresaFunc);

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

        //telefone
        public void InserirFoneFuncionario()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `fonefuncionario`(`idFoneFuncionario`, `numeroFuncionario`, `operFoneFuncionario`, `descFoneFuncionario`, `idFuncionario`) VALUES (DEFAULT,@numeroFone,@operFone,@descFone,@codFuncionario)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneFuncionario);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraFuncionario);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", variaveis.codFuncionario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DO Funcionario CADASTRADO COM SUCESSO!!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR TELEFONE DO FUNCIONÁRIO. \n\n" + ex);
            }
        }

        public void CarregarUltimoFuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT MAX(idFuncionario) FROM `funcionario`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.codFuncionario = dr.GetInt32(0);
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar último Funcionário \n\n" + ex);
            }
        }

        public void CarregarFoneFuncionario()
        {

            try
            {
                banco.Conectar();
                string inserir = "SELECT * FROM `fonefuncionario` WHERE `idFoneFuncionario`=@codigo";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFoneFuncionario);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.codFoneFuncionario = dr.GetInt32(0);
                    variaveis.numeroFoneFuncionario = dr.GetString(1);
                    variaveis.operadoraFuncionario = dr.GetString(2);
                    variaveis.descricaoFuncionario = dr.GetString(3);
                    variaveis.codFuncionario = dr.GetInt32(4);

                    txtCodigo.Text = variaveis.codFoneFuncionario.ToString();
                    mkdCadTelefone.Text = variaveis.numeroFoneFuncionario;
                    cmbOperadora.Text = variaveis.operadoraFuncionario;
                    txtDescricao.Text = variaveis.descricaoFuncionario;
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS DO TELEFONE. \n\n" + ex);
            }
        }

        public void AlterarFoneFuncionario()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `fonefuncionario` `numeroFuncionario`=@numeroFone, `operFoneFuncionario`=@operFone, `descFoneFuncionario`=@descFone  WHERE `idFoneFuncionario`=@codigo";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneFuncionario);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraFuncionario);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFoneFuncionario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DO FUNCIONÁRIO ATUALIZADO COM SUCESSO!!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ATUALIZAR O TELEFONE DO FUNCIONÁRIO. \n\n" + ex);
            }
        }

        public void CarregarTelefones()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM fonefuncionario WHERE `idFuncionario`=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario);
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
                CarregarFoneFuncionario();
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
            else if (cmbEmpresa.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar a empresa!");
                cmbEmpresa.Focus();
            }

            else
            {
                variaveis.nomeFuncionario = txtNomeFuncionario.Text;
                variaveis.emailFuncionario = txtEmail.Text;
                variaveis.senhaFuncionario = txtSenha.Text;
                variaveis.statusFuncionario = cmbStatus.Text;
                variaveis.nivelFuncionario = cmbNivel.Text;
                if (cmbEmpresa.Text == "BARBEARIA SR. JACK")
                {
                    variaveis.idEmpresaFunc = 1;
                }
                else if (cmbEmpresa.Text == "BARBEARIA SR. JACK FILIAL 1")
                {
                    variaveis.idEmpresaFunc = 2;
                }
                else if(cmbEmpresa.Text == "BARBEARIA SR. JACK FILIAL 2")
                {
                    variaveis.idEmpresaFunc = 3;
                }
                else if(cmbEmpresa.Text == "BARBEARIA SR. JACK FILIAL 3")
                {
                    variaveis.idEmpresaFunc = 4;
                }


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

        private void txtNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Enabled = true;
                txtEmail.Focus();
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

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Enabled = true;
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbNivel.Enabled = true;
                cmbNivel.Focus();
            }
        }

        private void cmbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCargaHoraria.Enabled = true;
                cmbCargaHoraria.Focus();
            }
        }

        private void cmbCargaHoraria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbEmpresa.Enabled = true;
                cmbEmpresa.Focus();
                
            }
        }

        private void lblAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR FONE";
            pnlCadFone.Visible = true;

            CarregarFoneFuncionario();

            pnlCadFone.Location = new Point(this.Width / 2 - pnlCadFone.Width / 2, this.Height / 2 - pnlCadFone.Height / 2);
        }

        private void btnFecharFone_Click(object sender, EventArgs e)
        {
            pnlCadFuncionario.Enabled = true;
            CarregarTelefones();
            pnlCadFone.Visible = false;
            pnlCadFone.Location = new Point(this.Width / 2 - pnlCadFone.Width / 2, this.Height / 2 - pnlCadFone.Height / 2);
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
                MessageBox.Show("Preencher a descricão");
                txtDescricao.Focus();
            }
            else
            {
                variaveis.numeroFoneFuncionario = mkdCadTelefone.Text;
                variaveis.operadoraFuncionario = cmbOperadora.Text;
                variaveis.descricaoFuncionario = txtDescricao.Text;

                if (variaveis.funcao == "CADASTRAR FONE")
                {
                    InserirFoneFuncionario();
                }
                else if (variaveis.funcao == "ALTERAR FONE")
                {
                    AlterarFoneFuncionario();
                }
            }
            //btnLimparFone.PerformClick();
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
                variaveis.codFoneFuncionario = Convert.ToInt32(dgvTelefone[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR FONE";
            pnlCadFone.Visible = true;
            pnlCadFone.Location = new Point(this.Width / 2 - pnlCadFone.Width / 2, this.Height / 2 - pnlCadFone.Height / 2);
            pnlCadFuncionario.Enabled = false;
            mkdCadTelefone.Focus();
        }

        private void cmbEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnSalvar.Enabled = true;
            btnSalvar.Focus();
        }
    }
}
