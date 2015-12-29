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

        private void mnuCustomerData_Click(object sender, EventArgs e)
        {
            frmCustomer formCustomer = new frmCustomer();
            formCustomer.MdiParent = this;
            formCustomer.Show();
        }

        private void mnuBuyDaily_Click(object sender, EventArgs e)
        {
            frmBuyGold formBuyGold = new frmBuyGold();
            formBuyGold.MdiParent = this;
            formBuyGold.Show();
        }

        private void mnuConsignmentDaily_Click(object sender, EventArgs e)
        {
            frmConsignment formConsignment = new frmConsignment();
            formConsignment.MdiParent = this;
            formConsignment.Show();
        }

        private void mnuInventoryInput_Click(object sender, EventArgs e)
        {
            frmInventory formInventory = new frmInventory();
            formInventory.MdiParent = this;
            formInventory.Show();
        }

        private void mnuInventoryProduct_Click(object sender, EventArgs e)
        {
            frmProduct formProduct = new frmProduct();
            formProduct.MdiParent = this;
            formProduct.Show();
        }

        private void mnuInventoryProductType_Click(object sender, EventArgs e)
        {
            frmProductDetails formProductDetails = new frmProductDetails();
            formProductDetails.MdiParent = this;
            formProductDetails.Show();
        }
    }
}
