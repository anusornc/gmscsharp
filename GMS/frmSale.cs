using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace GMS
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
           
        }

        private void FindCustomerById()
        {
            DBConnect dbConnect = new DBConnect();
            MySqlConnection connection = dbConnect.GetConnection();
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM customer where customer_uid = '" + txtCustomerID.Text + "'";
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtFirstName.Text = reader.GetString("customer_name");
                    txtLastName.Text = reader.GetString("customer_surname");
                } else
                {
                    MessageBox.Show("ไม่พบข้อมูลลูกค้า โปรดทำการลงทะเบียนลูกค้าก่อน");
                    status("ไม่พบข้อมูล");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            FindCustomerById();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();
            MySqlConnection connection = dbConnect.GetConnection();
            MySqlTransaction trans = null;

            try
            {
                connection.Open();
                trans = connection.BeginTransaction();

                MySqlCommand cmdInsert = connection.CreateCommand();
                MySqlCommand cmdUpdate = connection.CreateCommand();

                cmdInsert.Transaction = trans;
                cmdUpdate.Transaction = trans;


                cmdInsert.CommandText = " insert sale (customer_uid , product_id) " +
                    " VALUES ('" + txtCustomerID.Text + "' , '" +
                    txtProductID.Text + "')";
                cmdInsert.ExecuteNonQuery();

                cmdUpdate.CommandText = " update product set product_volumn = product_volumn -1 where product_id = '" + txtProductID.Text + "'";
                cmdUpdate.ExecuteNonQuery();

                trans.Commit();

                
                status("บันทึกการขายเรียบร้อย");
                FindProduct();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                btnFindCustomer_Click(sender,e);
                txtProductID.Focus();
            }
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                btnFindProduct_Click(sender, e);
            }
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            FindProduct();
        }

        private void FindProduct()
        {
            DBConnect dbConnect = new DBConnect();
            MySqlConnection connection = dbConnect.GetConnection();
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM product_detail where product_id = '" + txtProductID.Text + "'";
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtProductType.Text = reader.GetString("ptype_detail");
                    txtProductTexture.Text = reader.GetString("product_texture");
                    txtProductWeight.Text = reader.GetString("product_weight");
                    txtProductSalePrice.Text = reader.GetDouble("product_sale_price").ToString();
                    txtProductVolumn.Text = reader.GetInt16("product_volumn").ToString();
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลสินค้า โปรดทำการลงในทะเบียนในสินค้าคงคลังก่อน");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void status(String msg)
        {
            lblStatus.Text = " สถานะ :" + msg;
        }

        private void clear()
        {
            txtCustomerID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtProductID.Text = "";
            txtProductType.Text = "";
            txtProductTexture.Text = "";
            txtProductWeight.Text = "";
            txtProductSalePrice.Text = "";
        }
    }
    
}
