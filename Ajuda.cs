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
    public partial class FrmAjuda : Form
    {
        public FrmAjuda()
        {
            InitializeComponent();
        }

        private void FrmAjuda_Load(object sender, EventArgs e)
        {
            pnlAjuda.Location = new Point(this.Width / 2 - pnlAjuda.Width / 2, this.Height / 2 - pnlAjuda.Height / 2); 
        }

        private void btnFecharAjuda_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Hide();
        }
    }
}
