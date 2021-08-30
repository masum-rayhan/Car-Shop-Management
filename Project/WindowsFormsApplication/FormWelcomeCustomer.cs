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

namespace CarShopManagement
{
    public partial class FormWelcomeCustomer : Form
    {
       
        public UCCarlist uccarlist = new UCCarlist();
        public UCPurchasedHistory history = new UCPurchasedHistory();


        internal string Sql { get; set; }
        private FormLogin Fl { get; set; }

        public FormWelcomeCustomer()
        {
            InitializeComponent();
        }

        public FormWelcomeCustomer(FormLogin fl)
        {
            InitializeComponent();
            this.Fl = fl;
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uccarlist);
        }

        private void btnPurchasedHistory_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(history);
            history.txtCustomerID.Text = c_id.Text;
            history.PopulateGridViewForpurchasedhistory();
        }

        private void FormWelcomeCustomer_Load(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uccarlist);
            uccarlist.txtCustomerID.Text = c_id.Text;
        }

        private void FormWelcomeCustomer_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin one = new FormLogin();
            one.Show();
        }
    }
}

