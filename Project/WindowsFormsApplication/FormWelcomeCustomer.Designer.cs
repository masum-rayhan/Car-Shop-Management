namespace CarShopManagement
{
    partial class FormWelcomeCustomer
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
            this.btnPurchasedHistory = new System.Windows.Forms.Button();
            this.btnCarList = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.c_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPurchasedHistory
            // 
            this.btnPurchasedHistory.Location = new System.Drawing.Point(7, 262);
            this.btnPurchasedHistory.Name = "btnPurchasedHistory";
            this.btnPurchasedHistory.Size = new System.Drawing.Size(142, 28);
            this.btnPurchasedHistory.TabIndex = 17;
            this.btnPurchasedHistory.Text = "Purchased History";
            this.btnPurchasedHistory.UseVisualStyleBackColor = true;
            this.btnPurchasedHistory.Click += new System.EventHandler(this.btnPurchasedHistory_Click);
            // 
            // btnCarList
            // 
            this.btnCarList.Location = new System.Drawing.Point(7, 181);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(142, 28);
            this.btnCarList.TabIndex = 16;
            this.btnCarList.Text = "Car List";
            this.btnCarList.UseVisualStyleBackColor = true;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
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
            // c_id
            // 
            this.c_id.Location = new System.Drawing.Point(31, 6);
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            this.c_id.Size = new System.Drawing.Size(100, 22);
            this.c_id.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // FormWelcomeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 734);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_id);
            this.Controls.Add(this.btnPurchasedHistory);
            this.Controls.Add(this.btnCarList);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Name = "FormWelcomeCustomer";
            this.Text = "FormWelcomeCustomer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWelcomeCustomer_FormClosed_1);
            this.Load += new System.EventHandler(this.FormWelcomeCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPurchasedHistory;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox c_id;
        private System.Windows.Forms.Label label2;
    }
}