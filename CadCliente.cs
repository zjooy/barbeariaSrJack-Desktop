﻿using System;
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

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Hide();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);

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
    }
}
