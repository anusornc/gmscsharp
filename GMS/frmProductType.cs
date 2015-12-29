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
    public partial class frmProductType : Form
    {
        public frmProductType()
        {
            InitializeComponent();
        }

        String sql = "SELECT ptype_id, ptype_detail FROM product_type";
        MySqlDataAdapter adapter = null;
        DataSet ds = null;
        BindingSource bs = null;
        MySqlCommandBuilder cmd = null;
        private void frmProductType_Load(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();
            MySqlConnection connection = dbConnect.GetConnection();
            
            
            if (connection.State == ConnectionState.Closed)  connection.Open();
            
            adapter = new MySqlDataAdapter(sql, connection);
            cmd = new MySqlCommandBuilder(adapter);

            adapter.InsertCommand = cmd.GetInsertCommand();
            adapter.UpdateCommand = cmd.GetUpdateCommand();
            adapter.DeleteCommand = cmd.GetDeleteCommand();

            ds = new DataSet();
            adapter.Fill(ds,"product_type");

            bs = new BindingSource();
            bs.DataSource = ds.Tables[0].DefaultView;
            bindingNavigatorProductType.BindingSource = bs;

            dgvProductType.DataSource = null;
            dgvProductType.DataSource=bs;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.bs.EndEdit();
                this.adapter.Update(ds, "product_type");
                ds.AcceptChanges();
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจที่จะทำการลบ ?", "คำเตือน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.bs.RemoveCurrent();
            }
        }

        private void dgvProductType_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductType_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (ds.HasChanges())
            {
                dgvProductType.EndEdit();
                btnSave_Click(sender, e);
            }
        }
    }
}
