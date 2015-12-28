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
    public partial class frmCustomer : Form
    {
        private bool isupdate = true;

        public frmCustomer()
        {
            InitializeComponent();
            enableControl(false);
            btnFindCustomerID.Enabled = false;

            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Find Customer Fist If not found then add new
            btnFindCustomerID.Enabled = true;
            enableControl(false);
            txtCustomerUID.Enabled = true;
            clear();
            isupdate = false;
            txtCustomerUID.Focus();
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void clear()
        {
            status("เตรียมข้อมูล");
            txtCustomerUID.Text = "";
            txtCustomerBirthDate.Text = "";
            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerAddressTambon.Text = "";
            txtCustomerAddressAumphur.Text = "";
            txtCustomerAddressProvince.Text = "";
            txtCustomerAddressZip.Text = "";
            txtCustomersTel.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerNote.Text = "";

        }

        private void status(String msg) {
            lblStatus.Text = "สถานะ :" + msg;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            // Find Customer Fist If not found then add new
            btnFindCustomerID.Enabled = true;
            enableControl(false);
            txtCustomerUID.Enabled = true;
            txtCustomerUID.Focus();
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            status("แก้ไขข้อมูล");            
        }

        private void enableControl(bool locked)
        {
            txtCustomerUID.Enabled = locked;
            txtCustomerBirthDate.Enabled = locked;
            txtCustomerName.Enabled = locked;
            txtCustomerSurname.Enabled = locked;
            txtCustomerAddress.Enabled = locked;
            txtCustomerAddressTambon.Enabled = locked;
            txtCustomerAddressAumphur.Enabled = locked;
            txtCustomerAddressProvince.Enabled = locked;
            txtCustomerAddressZip.Enabled = locked;
            txtCustomersTel.Enabled = locked;
            txtCustomerEmail.Enabled = locked;
            txtCustomerNote.Enabled = locked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();
            MySqlConnection connection = dbConnect.GetConnection();
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                if (isupdate)
                {
                    cmd.CommandText = "update customer " +
                        " set customer_uid = '" + txtCustomerUID.Text + "'," +
                        " customer_name = '" + txtCustomerName.Text + "'," +
                        " customer_surname = '" + txtCustomerName.Text + "'," +
                        " customer_birthdate = '" + txtCustomerBirthDate.Text + "'," +
                        " customer_address = '" + txtCustomerAddress.Text + "'," +
                        " customer_addresstambon = '" + txtCustomerAddressTambon.Text + "'," +
                        " customer_addressaumphur = '" + txtCustomerAddressAumphur.Text + "'," +
                        " customer_addressprovince = '" + txtCustomerAddressProvince.Text + "'," +
                        " customer_addresszip ='" + txtCustomerAddressZip.Text + "'," +
                        " customer_tel = '" + txtCustomersTel.Text + "'," +
                        " customer_email = '" + txtCustomerEmail.Text + "'," +
                        " customer_note = '" + txtCustomerNote.Text + "'" +
                        " where customer_uid = '" + txtCustomerUID.Text + "'";
                }
                else
                {
                    cmd.CommandText = "insert into customer (customer_uid ,customer_name ,customer_surname," +
                        " customer_birthdate , customer_address , customer_addresstambon ," +
                        " customer_addressaumphur , customer_addressprovince , customer_addresszip ," +
                        " customer_tel , customer_email , customer_note )" +
                        " values ('" + txtCustomerUID.Text + "'," +
                        " '" + txtCustomerName.Text + "'," +
                        " '" + txtCustomerSurname.Text + "'," +
                        " '" + txtCustomerBirthDate.Text + "'," +
                        " '" + txtCustomerAddress.Text + "'," +
                        " '" + txtCustomerAddressTambon.Text + "'," +
                        " '" + txtCustomerAddressAumphur.Text + "'," +
                        " '" + txtCustomerAddressProvince.Text + "'," +
                        " '" + txtCustomerAddressZip.Text + "'," +
                        " '" + txtCustomersTel.Text + "'," +
                        " '" + txtCustomerEmail.Text + "'," +
                        " '" + txtCustomerNote.Text + "')";
                }
                cmd.ExecuteNonQuery();

                enableControl(false);
                status("บันทึกข้อมูลเรียบร้อย");
                btnNew.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;


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

        private void btnFindCustomerID_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();
            MySqlConnection connection = dbConnect.GetConnection();
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                
                cmd.CommandText = "SELECT * FROM customer where customer_uid = '" + txtCustomerUID.Text + "'";
               // MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                MySqlDataReader reader = cmd.ExecuteReader();

                //DataSet ds = new DataSet();
                //adapter.Fill(ds);

                btnNew.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;

                enableControl(true);
                if (reader.Read())
                {
                    isupdate = true;
                    btnDelete.Enabled = true;

                    txtCustomerName.Text = reader.GetString("customer_uid");
                    txtCustomerSurname.Text = reader.GetString("customer_surname");
                    txtCustomerBirthDate.Text = reader.GetString("customer_birthdate");
                    txtCustomerAddress.Text = reader.GetString("customer_address");
                    txtCustomerAddressTambon.Text = reader.GetString("customer_addresstambon");
                    txtCustomerAddressAumphur.Text = reader.GetString("customer_addressaumphur");
                    txtCustomerAddressProvince.Text = reader.GetString("customer_addressprovince");
                    txtCustomerAddressZip.Text = reader.GetString("customer_addresszip");
                    txtCustomersTel.Text = reader.GetString("customer_tel");
                    txtCustomerEmail.Text = reader.GetString("customer_email");
                    txtCustomerNote.Text = reader.GetString("customer_note");

                    status("พบข้อมูล : สามารถแก้ไข");
                    isupdate = true;
                   

                }
                else
                {
                    status("ไม่พบข้อมูล สามารถลงทะเบียนใหม่");
                    isupdate = false;
                    txtCustomerName.Focus();
                }
               

                //dtgCustomer.DataSource = ds.Tables[0].DefaultView;
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

        private void txtCustomerUID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFindCustomerID_Click(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if ((txtCustomerUID.Text.Trim().Length > 0) && 
                MessageBox.Show("แน่ใจว่าจะลบข้อมูล ?","ยนยันการลบข้อมูล",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBConnect dbConnect = new DBConnect();
                MySqlConnection connection = dbConnect.GetConnection();
                try
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "delete from customer where customer_uid = '" + txtCustomerUID.Text + "'";
                    cmd.ExecuteNonQuery();

                    clear();

                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;

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
            else {
                MessageBox.Show("ไม่พบข้อมูลสำหรับการลบ");
                status("ไม่พบข้อมูล");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
