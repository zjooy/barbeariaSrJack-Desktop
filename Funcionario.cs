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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void CarregarFuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM funcionariocompleto;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                dgvFuncionario.DataSource = dt;

                dgvFuncionario.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Funcionarios! \n\n" + ex);
            }
        }

        private void CarregarFuncionarioAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM funcionarioativo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;

                dgvFuncionario.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de funcionários ativos!! \n\n" + ex);
            }
        }

        private void CarregarFuncionarioInativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM funcionarioinativo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;

                dgvFuncionario.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de funcionários inativos!! \n\n" + ex);
            }
        }

        private void CarregarFuncionarioNome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM funcionariocompleto WHERE `NOME FUNCIONÁRIO` LIKE '%" + variaveis.nomeFuncionario + "%';";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;

                dgvFuncionario.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar o funcionário pelo nome!! \n\n" + ex);
            }
        }

        private void ExcluirFuncionario()
        {
            try
            {
                banco.Conectar();
                string excluir = "UPDATE `funcionario` SET `statusFuncionario`='INATIVO' WHERE idFuncionario = @codFuncionario;";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codFuncionario", variaveis.codFuncionario);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;
                dgvFuncionario.ClearSelection();
                banco.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir funcionario!!"+erro.Message);
            }
        }
        //STATUS RESERVA (EXCLUIR)
        public void AtualizarStatusReserva()
        {
            try
            {
                banco.Conectar();
                string inserir = "UPDATE `reserva` SET `statusReserva`='EXCLUIDA' WHERE idFuncionario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir a reserva!!\n\n" + erro, "ERRO");
            }
        }
        private void pctVoltar_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Hide();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            pnlFuncionario.Location = new Point(this.Width / 2 - pnlFuncionario.Width / 2, this.Height / 2 - pnlFuncionario.Height / 2);

            variaveis.linhaSelecionada = -1;

            CarregarFuncionario();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmCadFuncionario().Show();
            Hide();
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeFuncionario = txtFuncionario.Text;

            if (variaveis.nomeFuncionario == "")
            {
                cmbStatus.Enabled = true;
                cmbStatus.Text = "TODOS";
                CarregarFuncionario();
            }
            else
            {
                cmbStatus.Enabled = false;
                cmbStatus.Text = "TODOS";
                CarregarFuncionarioNome();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO")
            {
                CarregarFuncionarioAtivo();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarFuncionarioInativo();
            }
            else
            {
                CarregarFuncionario();
            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codFuncionario = Convert.ToInt32(dgvFuncionario[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvFuncionario_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFuncionario.Sort(dgvFuncionario.Columns[1], ListSortDirection.Ascending);
            dgvFuncionario.ClearSelection();
        }

        private void lblAlterar_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                new frmCadFuncionario().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha!");
            }
        }

        private void lblExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    AtualizarStatusReserva();
                    ExcluirFuncionario();
                    CarregarFuncionario();
                }
            }
        }
    }
}
