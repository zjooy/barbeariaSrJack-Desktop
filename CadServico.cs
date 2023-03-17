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
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void CarregarDadosServico()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `servico` WHERE idServico=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codServico);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.idEmpresa = dr.GetInt32(0);
                    variaveis.nomeServico = dr.GetString(1);
                    variaveis.valorServico = dr.GetDecimal(2);
                    variaveis.statusServico = dr.GetString(3);
                    variaveis.dataCadServico = dr.GetDateTime(4);
                    variaveis.descricaoServico = dr.GetString(5);
                    variaveis.tempoExcServico = DateTime.Parse(dr.GetString(6));
                    variaveis.idEmpresa = dr.GetInt32(7);

                    txtCodigo.Text = variaveis.codServico.ToString();
                    txtNomeServico.Text = variaveis.nomeServico;
                    txtValorServico.Text = variaveis.valorServico.ToString();
                    cmbStatus.Text = variaveis.statusServico;
                    mkdDataDeCadastro.Text = variaveis.dataCadServico.ToString("dd/MM/yyyy");
                    txtDescricao.Text = variaveis.descricaoServico;
                    cmbExc.Text = variaveis.tempoExcServico.ToString("HH:mm");
                    //DEPOIS AUTOMZATIZAR
                    if (variaveis.idEmpresa == 1)
                    {
                        cmbEmpresa.Text = "BARBEARIA SR. JACK";
                    }
                    else if (variaveis.idEmpresa == 2)
                    {
                        cmbEmpresa.Text = "BARBEARIA SR. JACK FILIAL 1";
                    }
                    else if (variaveis.idEmpresa == 3)
                    {
                        cmbEmpresa.Text = "BARBEARIA SR. JACK FILIAL 2";
                    }
                    else if (variaveis.idEmpresa == 4)
                    {
                        cmbEmpresa.Text = "BARBEARIA SR. JACK FILIAL 3";
                    }

                    banco.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Serviço! \n\n" + ex);
            }
        }

        private void InserirServico()
        {
            //DEPOIS AUTOMZATIZAR
            if (cmbEmpresa.Text == "BARBEARIA SR. JACK")
            {
                variaveis.idEmpresa = 1;
            }
            else if (cmbEmpresa.Text == "BARBEARIA SR. JACK FILIAL 1")
            {
                variaveis.idEmpresa = 2;
            }
            else if (cmbEmpresa.Text == "BARBEARIA SR. JACK FILIAL 2")
            {
                variaveis.idEmpresa = 3;
            }
            else if (cmbEmpresa.Text == "BARBEARIA SR. JACK FILIAL 3")
            {
                variaveis.idEmpresa = 4;
            }

            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `servico`(`idServico`, `nomeServico`, `valorServico`, `statusServico`, `dataCadServico`, `descricaoServico`, `tempoExcServico`, `idEmpresa`) VALUES (DEFAULT,@nomeServico,@valor,@statusServico,@dataCadServico,@descricao,@tempo,@codEmpresa)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeServico", variaveis.nomeServico);
                cmd.Parameters.AddWithValue("@valor", variaveis.valorServico);
                cmd.Parameters.AddWithValue("@statusServico", variaveis.statusServico);
                cmd.Parameters.AddWithValue("@dataCadServico", variaveis.dataCadServico.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@descricao", variaveis.descricaoServico);
                cmd.Parameters.AddWithValue("@tempo", variaveis.horarioAtendEmpresa.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@statusEmpresa", variaveis.tempoExcServico);
                cmd.Parameters.AddWithValue("@codEmpresa", variaveis.idEmpresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DO SERVIÇO REALIZADO COM SUCESSO!!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR O SERVIÇO. \n\n" + ex);
            }
        }

        private void AlterarServico()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `servico` SET `nomeServico`=@nomeServico,`valorServico`=@valor,`statusServico`=@statusServico,`descricaoServico`=@descricaoServico,`tempoExcServico`=@tempo WHERE `idServico` = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codServico);
                cmd.Parameters.AddWithValue("@nomeServico", variaveis.nomeServico);
                cmd.Parameters.AddWithValue("@valor", variaveis.valorServico);
                cmd.Parameters.AddWithValue("@statusServico", variaveis.statusServico);
                cmd.Parameters.AddWithValue("@descricaoServico", variaveis.descricaoServico);
                cmd.Parameters.AddWithValue("@tempo", variaveis.tempoExcServico);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DO SERVIÇO REALIZADA COM SUCESSO!!", "ALTERAR");

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o serviço. \n\n" + ex);
            }
        }

        public void CarregarUltimoServico()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT MAX(idServico) FROM `servico`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.codServico = dr.GetInt32(0);
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar último serviço \n\n" + ex);
            }
        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            pnlCadServico.Location = new Point(this.Width / 2 - pnlCadServico.Width / 2, this.Height / 2 - pnlCadServico.Height / 2);

            if (variaveis.funcao == "ALTERAR")
            {
                CarregarDadosServico();
                lblCadastrarServico.Text = "ALTERAR SERVIÇO";
            }

            if (txtCodigo.Text != "")
            {
                btnSalvar.Enabled = true;
                txtValorServico.Enabled = true;
                txtDescricao.Enabled = true;
                cmbStatus.Enabled = true;
                cmbEmpresa.Enabled = true;
            }
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            new frmServico().Show();
            Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeServico.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o serviço!");
                txtNomeServico.Focus();
            }
            else if (txtValorServico.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o valor do serviço!");
                txtValorServico.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status!");
                cmbStatus.Focus();
            }
            else if (cmbExc.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o tempo de execução!");
                cmbExc.Focus();
            }
            if (txtDescricao.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher a descrição!");
                txtDescricao.Focus();
            }
            else if (cmbEmpresa.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar a empresa!");
                cmbEmpresa.Focus();
            }
            else
            {
                variaveis.nomeServico = txtNomeServico.Text;
                variaveis.valorServico = Convert.ToDecimal(txtValorServico.Text);
                variaveis.statusServico = cmbStatus.Text;
                variaveis.tempoExcServico = DateTime.Parse(cmbExc.Text);
                variaveis.descricaoServico = txtDescricao.Text;
                if (variaveis.funcao == "CADASTRAR")
                {
                    mkdDataDeCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    variaveis.dataCadServico = DateTime.Parse(mkdDataDeCadastro.Text);
                }

                if (cmbEmpresa.Text == "BARBEARIA SR. JACK")
                {
                    variaveis.idEmpresa = 1;
                }
                else if (cmbEmpresa.Text == "BARBEARIA SR. JACK FILIAL 1")
                {
                    variaveis.idEmpresa = 2;
                }
                else if (cmbEmpresa.Text == "BARBEARIA SR. JACK FILIAL 2")
                {
                    variaveis.idEmpresa = 3;
                }
                else if (cmbEmpresa.Text == "BARBEARIA SR. JACK FILIAL 3")
                {
                    variaveis.idEmpresa = 4;
                }

                if (variaveis.funcao == "CADASTRAR")
                {
                    InserirServico();
                    CarregarUltimoServico();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    AlterarServico();
                }
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        private void txtNomeServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtValorServico.Enabled = true;
                txtValorServico.Focus();
            }
        }

        private void cmbValorServico_KeyPress(object sender, KeyPressEventArgs e)
        {            
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbExc.Enabled = true;
                cmbExc.Focus();
            }
        }

        private void cmbExc_KeyPress(object sender, KeyPressEventArgs e)
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
                cmbEmpresa.Enabled = true;
                cmbEmpresa.Focus();
            }
        }

        private void cmbEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Enabled = true;
                btnSalvar.Focus();
            }
        }

        private void txtValorServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Enabled = true;
                cmbStatus.Focus();
            }
        }
    }
}
