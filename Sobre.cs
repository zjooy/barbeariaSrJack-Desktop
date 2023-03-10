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
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {
            pnlSobre.Location = new Point(this.Width / 2 -pnlSobre.Width / 2, this.Height / 2 - pnlSobre.Height / 2);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Hide();
        }
    }
}
