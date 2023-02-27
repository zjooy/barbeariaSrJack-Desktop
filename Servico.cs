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
    public partial class frmServico : Form
    {
        public frmServico()
        {
            InitializeComponent();
        }
        //FAZER VIEW SERVICO
        private void CarregarServico()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `servicocompleto`;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvServico.DataSource = dt;

                dgvServico.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de serviços!! \n\n" + ex);
            }
        }

        private void CarregarServicoAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM servicoativo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvServico.DataSource = dt;

                dgvServico.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de serviços ativos!! \n\n" + ex);
            }
        }

        private void CarregarServicoInativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM servicoinativo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvServico.DataSource = dt;

                dgvServico.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de serviços inativos!! \n\n" + ex);
            }
        }

        private void CarregarServicoNome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM servicocompleto WHERE `NOME SERVIÇO` LIKE '%" + variaveis.nomeServico + "%';";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvServico.DataSource = dt;

                dgvServico.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar servico pelo nome!! \n\n" + ex);
            }
        }


        private void frmServico_Load(object sender, EventArgs e)
        {
            pnlServico.Location = new Point(this.Width / 2 - pnlServico.Width / 2, this.Height / 2 - pnlServico.Height / 2);

            variaveis.linhaSelecionada = -1;

            CarregarServico();
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Hide();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";

            //new frmCadCliente().Show();
            //Hide();
        }

        private void txtServico_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeServico = txtServico.Text;

            if (variaveis.nomeServico == "")
            {
                cmbStatus.Enabled = true;
                cmbStatus.Text = "TODOS";
                CarregarServico();
            }
            else
            {
                cmbStatus.Enabled = false;
                cmbStatus.Text = "TODOS";
                CarregarServicoNome();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO")
            {
                CarregarServicoAtivo();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarServicoInativo();
            }
            else
            {
                CarregarServico();
            }
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codServico = Convert.ToInt32(dgvServico[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvServico_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvServico.Sort(dgvServico.Columns[1], ListSortDirection.Ascending);
            dgvServico.ClearSelection();
        }

        private void lblAlterar_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                new frmCadCliente().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha!");
            }
        }
    }
}
