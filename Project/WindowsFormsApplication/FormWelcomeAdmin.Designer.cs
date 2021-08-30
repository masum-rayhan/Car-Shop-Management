namespace CarShopManagement
{
    partial class FormWelcomeAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnUserlist = new System.Windows.Forms.Button();
            this.btnCarList = new System.Windows.Forms.Button();
            this.btnSoledCars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(409, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Car Shop Mangement System ";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1248, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(83, 31);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Info;
            this.pnlMain.Location = new System.Drawing.Point(160, 69);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1204, 662);
            this.pnlMain.TabIndex = 6;
            // 
            // btnUserlist
            // 
            this.btnUserlist.Location = new System.Drawing.Point(12, 120);
            this.btnUserlist.Name = "btnUserlist";
            this.btnUserlist.Size = new System.Drawing.Size(122, 28);
            this.btnUserlist.TabIndex = 0;
            this.btnUserlist.Text = "Manage Users";
            this.btnUserlist.UseVisualStyleBackColor = true;
            this.btnUserlist.Click += new System.EventHandler(this.btnUserlist_Click);
            // 
            // btnCarList
            // 
            this.btnCarList.Location = new System.Drawing.Point(12, 193);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(122, 28);
            this.btnCarList.TabIndex = 8;
            this.btnCarList.Text = "Manage Cars";
            this.btnCarList.UseVisualStyleBackColor = true;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // btnSoledCars
            // 
            this.btnSoledCars.Location = new System.Drawing.Point(12, 274);
            this.btnSoledCars.Name = "btnSoledCars";
            this.btnSoledCars.Size = new System.Drawing.Size(122, 28);
            this.btnSoledCars.TabIndex = 11;
            this.btnSoledCars.Text = "Soled Cars";
            this.btnSoledCars.UseVisualStyleBackColor = true;
            this.btnSoledCars.Click += new System.EventHandler(this.btnSoledCars_Click);
            // 
            // FormWelcomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1367, 734);
            this.Controls.Add(this.btnSoledCars);
            this.Controls.Add(this.btnCarList);
            this.Controls.Add(this.btnUserlist);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Name = "FormWelcomeAdmin";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWelcome_FormClosed);
            this.Load += new System.EventHandler(this.FormWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnUserlist;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Button btnSoledCars;
    }
}