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
    public partial class frmMenu : Form
    {
        int hora = DateTime.Now.Hour;
        int clickAgenda;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resposta == DialogResult.No)
            {
                new frmLogin().Show();
                Close();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlMenu.Location = new Point(this.Width / 2 - pnlMenu.Width / 2, this.Height / 2 - pnlMenu.Height / 2);


            if (hora >= 6 && hora <= 12)
            {
                lblMensagem.Text = "Bom dia, " + "Joyce" + "!";
            }
            else if (hora >= 12 && hora < 18)
            {
                lblMensagem.Text = "Boa tarde, " + "Joyce" + "!";
            }
            else
            {
                lblMensagem.Text = "Boa noite, " + "Joyce" + "!";
            }

        }

        private void pctAgenda_Click(object sender, EventArgs e)
        {
            if (clickAgenda == 0)
            {
                btnAgendar.Visible = true;
                btnAguardar.Visible = true;
                btnAprovar.Visible = true;
                btnCancelar.Visible = true;
                btnEditar.Visible = true;
                btnFinalizar.Visible = true;

                clickAgenda = 1;
            }
            else
            {
                esconderBotoes();
            }
        }

        private void esconderBotoes()
        {
            btnAgendar.Visible = false;
            btnAguardar.Visible = false;
            btnAprovar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = false;
            btnFinalizar.Visible = false;

            clickAgenda = 0;
        }

        

        private void pctEmpresa_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Hide();
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            esconderBotoes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            esconderBotoes();
        }

        private void btnAguardar_Click(object sender, EventArgs e)
        {
            esconderBotoes();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            esconderBotoes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esconderBotoes();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            esconderBotoes();
        }

        private void pctCliente_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Hide();
        }

        private void pctFuncionario_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Hide();
        }
    }
}
