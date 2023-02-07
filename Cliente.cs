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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void CarregarCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM clientecompleto;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de clientes!! \n\n" + ex);
            }
        }

        private void CarregarClienteAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM clienteativo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de clientes ativos!! \n\n" + ex);
            }
        }

        private void CarregarClienteInativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM clienteinativo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de clientes inativos!! \n\n" + ex);
            }
        }

        private void CarregarClienteNome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM clientecompleto WHERE `NOME CLIENTE` LIKE '%" + variaveis.nomeCliente + "%';";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar cliente pelo nome!! \n\n" + ex);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            pnlCliente.Location = new Point(this.Width / 2 - pnlCliente.Width / 2, this.Height / 2 - pnlCliente.Height / 2);

            CarregarCliente();

        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Hide();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadCliente().Show();
            Hide();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeCliente = txtCliente.Text;

            if (variaveis.nomeCliente == "")
            {
                cmbStatus.Enabled = true;
                cmbStatus.Text = "TODOS";
                CarregarCliente();
            }
            else
            {
                cmbStatus.Enabled = false;
                cmbStatus.Text = "TODOS";
                CarregarClienteNome();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO")
            {
                CarregarClienteAtivo();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarClienteInativo();
            }
            else
            {
                CarregarCliente();
            }
        }
    }
}
