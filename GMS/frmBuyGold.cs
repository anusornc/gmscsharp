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
    public partial class frmBuyGold : Form
    {
        public frmBuyGold()
        {
            InitializeComponent();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            FindCustomerById();
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
                    status("เตรียมป้อนข้อมูลการซื้อ");
                    txtProductName.Focus();
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลลูกค้า โปรดทำการลงทะเบียนลูกค้าก่อน");
                    status("ไม่พบข้อมูล");
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
            lblStatus.Text = "สถานะ : " + msg;
        }

        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)13) && (txtCustomerID.Text.Trim().Length >0)) {
                FindCustomerById();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Trim().Length > 0 &&
                txtProductName.Text.Trim().Length > 0 &&
                txtProductBuyPrice.Text.Trim().Length > 0)
            {
                Save();
            }
        }

        private void Save()
        {
            DBConnect dbConnect = new DBConnect();
            MySqlConnection connection = dbConnect.GetConnection();
            //MySqlTransaction trans = null;

            try
            {
                connection.Open();
                //trans = connection.BeginTransaction();

                MySqlCommand cmdInsert = connection.CreateCommand();
               // MySqlCommand cmdUpdate = connection.CreateCommand();

               // cmdInsert.Transaction = trans;
               // cmdUpdate.Transaction = trans;


                cmdInsert.CommandText = " insert into buy (customer_uid , buy_product_name " +
                    " ,buy_product_type,buy_product_texture, buy_product_weight,buy_product_price) " +
                    " VALUES ('" + txtCustomerID.Text + "' ," +
                    " '" + txtProductName.Text + "'," + 
                    " '" + txtProductType.Text + "'," +
                    " '" + txtProductTexture.Text + "'," + 
                    txtProductWeight.Text +  "," +
                    txtProductBuyPrice.Text +")";
                cmdInsert.ExecuteNonQuery();

                //cmdUpdate.CommandText = " update product set product_volumn = product_volumn -1 where product_id = '" + txtProductID.Text + "'";
                //cmdUpdate.ExecuteNonQuery();

                //trans.Commit();


                status("บันทึกการซื้อเรียบร้อย");

            }
            catch (Exception ex)
            {
                //trans.Rollback();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    // Any action
                    TextBox textBox = control as TextBox;
                    textBox.Clear();
                }
            }

            foreach (Control c in groupBox1.Controls) {
                if (c is TextBox)
                {
                    // Any action
                    TextBox textBox = c as TextBox;
                    textBox.Clear();
                }
            }
        }
    }
}
