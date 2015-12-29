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

namespace GMS
{
    public partial class frmProductDetails : Form
    {
        public frmProductDetails()
        {
            InitializeComponent();
        }

        String sqlProductType = "SELECT ptype_id, ptype_detail FROM product_type";
        String sqlProduct = "SELECT * FROM product";
        MySqlDataAdapter adapterProductType = null;
        MySqlDataAdapter adapterProduct = null;

        DataSet dsMasterDetail = null;

        BindingSource bsProductType = null;
        BindingSource bsProduct = null;

        MySqlCommandBuilder cmdProductType = null;
        MySqlCommandBuilder cmdProduct = null;


        private void frmProductType_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            DBConnect dbConnect = new DBConnect();
            MySqlConnection connection = dbConnect.GetConnection();


            if (connection.State == ConnectionState.Closed) connection.Open();

            adapterProductType = new MySqlDataAdapter(sqlProductType, connection);
            cmdProductType = new MySqlCommandBuilder(adapterProductType);

            adapterProduct = new MySqlDataAdapter(sqlProduct, connection);
            cmdProduct = new MySqlCommandBuilder(adapterProduct);

            adapterProductType.InsertCommand = cmdProductType.GetInsertCommand();
            adapterProductType.UpdateCommand = cmdProductType.GetUpdateCommand();
            adapterProductType.DeleteCommand = cmdProductType.GetDeleteCommand();

            adapterProduct.InsertCommand = cmdProduct.GetInsertCommand();
            adapterProduct.UpdateCommand = cmdProduct.GetUpdateCommand();
            adapterProduct.DeleteCommand = cmdProduct.GetDeleteCommand();
            


            dsMasterDetail = new DataSet();
            adapterProductType.Fill(dsMasterDetail, "product_type");
            adapterProduct.Fill(dsMasterDetail, "product");

            DataRelation relation = new DataRelation("ProductDetails", 
                dsMasterDetail.Tables["product_type"].Columns["ptype_id"], 
                dsMasterDetail.Tables["product"].Columns["ptype_id"]);

            dsMasterDetail.Relations.Add(relation);

            bsProductType = new BindingSource();
            bsProduct = new BindingSource();
            //bsProductType.DataSource = dsMasterDetail.Tables[0].DefaultView;

            
            bsProductType.DataSource = dsMasterDetail;
            bsProductType.DataMember = "product_type";
            bindingNavigatorProductType.BindingSource = bsProductType;

            bsProduct.DataSource = bsProductType;
            bsProduct.DataMember = "ProductDetails";
            bindingNavigatorProduct.BindingSource = bsProduct;

            dgvProductType.DataSource = null;
            dgvProductType.DataSource = bsProductType;

            dgvProduct.DataSource = null;
            dgvProduct.DataSource = bsProduct;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.bsProductType.EndEdit();
                this.adapterProductType.Update(dsMasterDetail, "product_type");
                dsMasterDetail.AcceptChanges();
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจที่จะทำการลบ ?", "คำเตือน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.bsProductType.RemoveCurrent();
            }
        }

        private void dgvProductType_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductType_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dsMasterDetail.HasChanges())
            {
                dgvProductType.EndEdit();
                btnSave_Click(sender, e);
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                this.bsProduct.EndEdit();
                this.adapterProduct.Update(dsMasterDetail, "product");
                dsMasterDetail.AcceptChanges();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvProduct_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dsMasterDetail.HasChanges())
            {
                dgvProduct.EndEdit();
                btnSaveProduct_Click(sender, e);
            }
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจที่จะทำการลบ ?", "คำเตือน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.bsProduct.RemoveCurrent();
            }
        }
    }
}
