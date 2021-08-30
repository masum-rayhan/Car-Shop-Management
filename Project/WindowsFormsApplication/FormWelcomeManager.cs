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
    public partial class FormWelcomeManager : Form
    {
        public UCCustomers customers = new UCCustomers();
        public UCCars uccars = new UCCars();
        public UCSoldHistory history = new UCSoldHistory();


        internal string Sql { get; set; }
        private FormLogin Fl { get; set; }

        public FormWelcomeManager()
        {
            InitializeComponent();
        }

        public FormWelcomeManager(FormLogin fl)
        {
            InitializeComponent();
            this.Fl = fl;
        }

        private void btnCustomerlist_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(customers);
        }

        private void btnCarList_Click_1(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uccars);
        }

        private void btnSoledCars_Click_1(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(history);
            history.PopulateGridViewForsoldhistory();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin one = new FormLogin();
            one.Show();
        }

        private void FormWelcomeManager_Load(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(customers);
        }

        private void FormWelcomeManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}