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
    public partial class frmCadastrarEmpresa : Form
    {
        public frmCadastrarEmpresa()
        {
            InitializeComponent();
        }

        private void frmCadastrarEmpresa_Load(object sender, EventArgs e)
        {
            pnlCadastrarEmpresa.Location = new Point(this.Width / 2 - pnlCadastrarEmpresa.Width / 2, this.Height / 2 - pnlCadastrarEmpresa.Height / 2);

            cmbDocumento.Text = "CNPJ";

            if (txtCodigo.Text != "")
            {
                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = true;
                cmbDocumento.Enabled = true;
                mkdCpfCnpj.Enabled = true;
                txtRazaoSocial.Enabled = true;
                txtEmail.Enabled = true;
                cmbStatus.Enabled = true;
                cmbCargaHoraria.Enabled = true;
            }

        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Hide();
        }
    }
}
