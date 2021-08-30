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
    public partial class FormWelcomeAdmin : Form
    {
        public UCUsers ucusers = new UCUsers();
        public UCCars uccars = new UCCars();
        public UCSoldHistory history = new UCSoldHistory();
        
       
        internal string Sql { get; set; }
        private FormLogin Fl { get; set; }

        public FormWelcomeAdmin()
        {
            InitializeComponent();
        }

        public FormWelcomeAdmin(FormLogin fl)
        {
            InitializeComponent();
            this.Fl = fl;
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin one = new FormLogin();
            one.Show();
        }

        private void FormWelcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUserlist_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(ucusers);
            
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uccars);
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(ucusers);
        }

        private void btnSoledCars_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(history);
            history.PopulateGridViewForsoldhistory();
        }
    }
}