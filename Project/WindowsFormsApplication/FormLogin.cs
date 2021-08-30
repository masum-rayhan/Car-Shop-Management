
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace CarShopManagement
{
    public partial class FormLogin : Form
    {


        public FormLogin()
        {

            InitializeComponent();
        }

        private bool Valid()
        {
            if (string.IsNullOrEmpty(this.txtU_ID.Text) ||
                string.IsNullOrEmpty(this.txtU_Password.Text))
            {
                return false;
            }
            else
                return true;
        }


        OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=AVENGERS;PASSWORD=mahadi");
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (Valid())
            {

                conn.Open();

                string query = "select * from CarShop_User where U_PASSWORD=" + txtU_Password.Text + " and U_ID=" + txtU_ID.Text + " ";



                OracleCommand cmd = new OracleCommand(query, conn);


                OracleDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    string usertype = dr["usertype"].ToString();
                    if (usertype == "Admin")
                    {
                        this.Hide();
                        FormWelcomeAdmin admin = new FormWelcomeAdmin();
                        admin.Show();
                    }

                    else if (usertype == "Manager")
                    {
                        this.Hide();
                        FormWelcomeManager manager = new FormWelcomeManager();
                        manager.Show();

                    }

                    else if (usertype == "Customer")
                    {
                        this.Hide();
                        FormWelcomeCustomer customer = new FormWelcomeCustomer();
                        customer.c_id.Text = txtU_ID.Text;                                        
                        customer.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Failed!");
                    }


                }
                else
                    MessageBox.Show("Incorrect UserId/Password ");
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please Enter your ID & Password");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            FormRegistration x = new FormRegistration();
            x.Show();
            this.Hide();

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
