namespace CarShopManagement
{
    partial class FormRegistration
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
            this.label2 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtUAddress = new System.Windows.Forms.TextBox();
            this.txtUPhone = new System.Windows.Forms.TextBox();
            this.txtUPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(30, 314);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(31, 17);
            this.City.TabIndex = 2;
            this.City.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(208, 158);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(100, 22);
            this.txtUID.TabIndex = 5;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(208, 204);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(100, 22);
            this.txtUName.TabIndex = 6;
            // 
            // txtUAddress
            // 
            this.txtUAddress.Location = new System.Drawing.Point(208, 257);
            this.txtUAddress.Name = "txtUAddress";
            this.txtUAddress.Size = new System.Drawing.Size(100, 22);
            this.txtUAddress.TabIndex = 7;
            // 
            // txtUPhone
            // 
            this.txtUPhone.Location = new System.Drawing.Point(208, 371);
            this.txtUPhone.Name = "txtUPhone";
            this.txtUPhone.Size = new System.Drawing.Size(100, 22);
            this.txtUPhone.TabIndex = 8;
            // 
            // txtUPassword
            // 
            this.txtUPassword.Location = new System.Drawing.Point(208, 428);
            this.txtUPassword.Name = "txtUPassword";
            this.txtUPassword.PasswordChar = '*';
            this.txtUPassword.Size = new System.Drawing.Size(100, 22);
            this.txtUPassword.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(220, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(33, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUCity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUPhone);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUPassword);
            this.panel1.Controls.Add(this.City);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUName);
            this.panel1.Controls.Add(this.txtUID);
            this.panel1.Location = new System.Drawing.Point(522, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 633);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone Number";
            // 
            // txtUCity
            // 
            this.txtUCity.Location = new System.Drawing.Point(208, 314);
            this.txtUCity.Name = "txtUCity";
            this.txtUCity.Size = new System.Drawing.Size(100, 22);
            this.txtUCity.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(93, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Registration";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1387, 731);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.TextBox txtUAddress;
        private System.Windows.Forms.TextBox txtUPhone;
        private System.Windows.Forms.TextBox txtUPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUCity;
    }
}