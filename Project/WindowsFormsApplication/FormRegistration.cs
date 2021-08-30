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
    public partial class FormRegistration : Form
    {

        public FormRegistration()
        {
            InitializeComponent();
           
        }

        private bool Valid()
        {
            if (string.IsNullOrEmpty(this.txtUID.Text) || string.IsNullOrEmpty(this.txtUName.Text) ||
                string.IsNullOrEmpty(this.txtUPassword.Text) ||
                string.IsNullOrEmpty(this.txtUAddress.Text) || string.IsNullOrEmpty(this.txtUCity.Text) || string.IsNullOrEmpty(this.txtUPhone.Text))
            {
                return false;
            }
            else
                return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                string query = "BEGIN insertinto_carshop_user('" + txtUID.Text + "','" + txtUName.Text + "','" + txtUPassword.Text + "','" + txtUAddress.Text + "','" + txtUCity.Text + "','" + txtUPhone.Text + "','Customer'); END; ";



                OracleConnection con = new OracleConnection("DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=AVENGERS;PASSWORD=mahadi");
                con.Open();

                OracleCommand cmd = new OracleCommand(query, con);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();

                    MessageBox.Show("Successfully Registered");
                    con.Close();
                    txtUID.Text = "";
                    txtUName.Text = "";
                    txtUAddress.Text = "";
                    txtUPhone.Text = "";
                    txtUPassword.Text = "";
                    txtUCity.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Used different ID");
                    con.Close();

                }
            }
            else
            {
                MessageBox.Show("Please fill all the information");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin x = new FormLogin();
            x.ShowDialog();
            this.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
