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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Hide();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            pnlCadFuncionario.Location = new Point(this.Width / 2 - pnlCadFuncionario.Width / 2, this.Height / 2 - pnlCadFuncionario.Height / 2);

        }
    }
}
