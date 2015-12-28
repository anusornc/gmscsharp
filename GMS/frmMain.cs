using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuSaleDaily_Click(object sender, EventArgs e)
        {
            frmSale formSale = new frmSale();
            formSale.MdiParent = this;
            formSale.Show();
        }
    }
}
