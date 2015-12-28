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

        }
    }
    
}
