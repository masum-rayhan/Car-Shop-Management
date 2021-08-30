namespace CarShopManagement
{
    partial class FormWelcomeManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSoledCars = new System.Windows.Forms.Button();
            this.btnCarList = new System.Windows.Forms.Button();
            this.btnCustomerlist = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSoledCars
            // 
            this.btnSoledCars.Location = new System.Drawing.Point(7, 262);
            this.btnSoledCars.Name = "btnSoledCars";
            this.btnSoledCars.Size = new System.Drawing.Size(122, 28);
            this.btnSoledCars.TabIndex = 17;
            this.btnSoledCars.Text = "Soled Cars";
            this.btnSoledCars.UseVisualStyleBackColor = true;
            this.btnSoledCars.Click += new System.EventHandler(this.btnSoledCars_Click_1);
            // 
            // btnCarList
            // 
            this.btnCarList.Location = new System.Drawing.Point(7, 181);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(94, 28);
            this.btnCarList.TabIndex = 16;
            this.btnCarList.Text = "Manage Cars";
            this.btnCarList.UseVisualStyleBackColor = true;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click_1);
            // 
            // btnCustomerlist
            // 
            this.btnCustomerlist.Location = new System.Drawing.Point(7, 108);
            this.btnCustomerlist.Name = "btnCustomerlist";
            this.btnCustomerlist.Size = new System.Drawing.Size(142, 28);
            this.btnCustomerlist.TabIndex = 12;
            this.btnCustomerlist.Text = "Manage Customers";
            this.btnCustomerlist.UseVisualStyleBackColor = true;
            this.btnCustomerlist.Click += new System.EventHandler(this.btnCustomerlist_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMain.Location = new System.Drawing.Point(155, 57);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1204, 662);
            this.pnlMain.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1243, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(83, 31);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(404, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome to Car Shop Mangement System ";
            // 
            // FormWelcomeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 734);
            this.Controls.Add(this.btnSoledCars);
            this.Controls.Add(this.btnCarList);
            this.Controls.Add(this.btnCustomerlist);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Name = "FormWelcomeManager";
            this.Text = "FormWelcomeManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWelcomeManager_FormClosed);
            this.Load += new System.EventHandler(this.FormWelcomeManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoledCars;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Button btnCustomerlist;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}