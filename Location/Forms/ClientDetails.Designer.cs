namespace Location.Forms
{
    partial class ClientDetails
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.dtp_brith_day = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_last_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_first_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_user_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_cin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_phone_number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_admin = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(134, 369);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Annuler";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(53, 369);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // dtp_brith_day
            // 
            this.dtp_brith_day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_brith_day.Location = new System.Drawing.Point(101, 172);
            this.dtp_brith_day.Name = "dtp_brith_day";
            this.dtp_brith_day.Size = new System.Drawing.Size(100, 20);
            this.dtp_brith_day.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Brithday :";
            // 
            // txb_last_name
            // 
            this.txb_last_name.Location = new System.Drawing.Point(101, 69);
            this.txb_last_name.Name = "txb_last_name";
            this.txb_last_name.Size = new System.Drawing.Size(100, 20);
            this.txb_last_name.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Last Name :";
            // 
            // txb_first_name
            // 
            this.txb_first_name.Location = new System.Drawing.Point(101, 43);
            this.txb_first_name.Name = "txb_first_name";
            this.txb_first_name.Size = new System.Drawing.Size(100, 20);
            this.txb_first_name.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "First Name :";
            // 
            // txb_user_name
            // 
            this.txb_user_name.Location = new System.Drawing.Point(106, 30);
            this.txb_user_name.Name = "txb_user_name";
            this.txb_user_name.Size = new System.Drawing.Size(100, 20);
            this.txb_user_name.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Client  UserName:";
            // 
            // txb_adresse
            // 
            this.txb_adresse.Location = new System.Drawing.Point(101, 114);
            this.txb_adresse.Name = "txb_adresse";
            this.txb_adresse.Size = new System.Drawing.Size(100, 20);
            this.txb_adresse.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Adresse :";
            // 
            // txb_cin
            // 
            this.txb_cin.Location = new System.Drawing.Point(101, 20);
            this.txb_cin.Name = "txb_cin";
            this.txb_cin.Size = new System.Drawing.Size(100, 20);
            this.txb_cin.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "CIN :";
            // 
            // txb_phone_number
            // 
            this.txb_phone_number.Location = new System.Drawing.Point(101, 140);
            this.txb_phone_number.Name = "txb_phone_number";
            this.txb_phone_number.Size = new System.Drawing.Size(100, 20);
            this.txb_phone_number.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Phone Number :";
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(101, 91);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(100, 20);
            this.txb_email.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Email :";
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(106, 56);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(100, 20);
            this.txb_password.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Client Password:";
            // 
            // cb_admin
            // 
            this.cb_admin.AutoSize = true;
            this.cb_admin.Location = new System.Drawing.Point(80, 81);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(55, 17);
            this.cb_admin.TabIndex = 33;
            this.cb_admin.Text = "Admin";
            this.cb_admin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_admin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txb_password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_user_name);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 104);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_email);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txb_cin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txb_phone_number);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txb_adresse);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtp_brith_day);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txb_last_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txb_first_name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(11, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 202);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Details";
            // 
            // ClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Name = "ClientDetails";
            this.Text = "ClientDetails";
            this.Load += new System.EventHandler(this.ClientDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DateTimePicker dtp_brith_day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_last_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_first_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_cin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_phone_number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cb_admin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}