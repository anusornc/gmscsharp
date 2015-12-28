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
                //cmd.CommandText = "SELECT * FROM gmsdb.sale_daily WHERE DATE(NOW()) = DATE(DATE_ADD(sale_date, INTERVAL 5 HOUR)) ;";
                cmd.CommandText = "SELECT * FROM customer where customer_uid = '" + txtCustomerID.Text + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    txtFirstName.Text = ds.Tables[0].Columns["customer_name"].ToString();
                    txtLastName.Text = ds.Tables[0].Columns["customer_surname"].ToString();
                }
                //dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (connection.State == ConnectionState.Open) {
                    connection.Clone();
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
    }
    
}
