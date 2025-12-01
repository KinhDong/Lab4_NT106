namespace Lab4_24520303_BuiCongDinh.Bai7
{
    partial class SignupForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            tb_Password = new TextBox();
            tb_Username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            cb_Sex = new ComboBox();
            cb_Language = new ComboBox();
            dtp_Birthday = new DateTimePicker();
            tb_Phone = new TextBox();
            tb_Lastname = new TextBox();
            tb_Firstname = new TextBox();
            tb_Email = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btn_Summit = new Button();
            btn_Clear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(176, 22);
            label1.Name = "label1";
            label1.Size = new Size(345, 46);
            label1.TabIndex = 1;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_Password);
            groupBox1.Controls.Add(tb_Username);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(50, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 167);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Signup";
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(171, 97);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(387, 31);
            tb_Password.TabIndex = 3;
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(171, 48);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(387, 31);
            tb_Username.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 100);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 51);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cb_Sex);
            groupBox2.Controls.Add(cb_Language);
            groupBox2.Controls.Add(dtp_Birthday);
            groupBox2.Controls.Add(tb_Phone);
            groupBox2.Controls.Add(tb_Lastname);
            groupBox2.Controls.Add(tb_Firstname);
            groupBox2.Controls.Add(tb_Email);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(50, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(600, 419);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Information";
            // 
            // cb_Sex
            // 
            cb_Sex.FormattingEnabled = true;
            cb_Sex.Items.AddRange(new object[] { "male", "female" });
            cb_Sex.Location = new Point(171, 369);
            cb_Sex.Name = "cb_Sex";
            cb_Sex.Size = new Size(387, 33);
            cb_Sex.TabIndex = 14;
            // 
            // cb_Language
            // 
            cb_Language.FormattingEnabled = true;
            cb_Language.Items.AddRange(new object[] { "en", "vi" });
            cb_Language.Location = new Point(171, 314);
            cb_Language.Name = "cb_Language";
            cb_Language.Size = new Size(387, 33);
            cb_Language.TabIndex = 13;
            // 
            // dtp_Birthday
            // 
            dtp_Birthday.Location = new Point(171, 260);
            dtp_Birthday.Name = "dtp_Birthday";
            dtp_Birthday.Size = new Size(387, 31);
            dtp_Birthday.TabIndex = 12;
            // 
            // tb_Phone
            // 
            tb_Phone.Location = new Point(171, 208);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.Size = new Size(387, 31);
            tb_Phone.TabIndex = 11;
            // 
            // tb_Lastname
            // 
            tb_Lastname.Location = new Point(171, 153);
            tb_Lastname.Name = "tb_Lastname";
            tb_Lastname.Size = new Size(387, 31);
            tb_Lastname.TabIndex = 10;
            // 
            // tb_Firstname
            // 
            tb_Firstname.Location = new Point(171, 103);
            tb_Firstname.Name = "tb_Firstname";
            tb_Firstname.Size = new Size(387, 31);
            tb_Firstname.TabIndex = 9;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(171, 53);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(387, 31);
            tb_Email.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 372);
            label10.Name = "label10";
            label10.Size = new Size(43, 25);
            label10.TabIndex = 7;
            label10.Text = "Sex:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 317);
            label9.Name = "label9";
            label9.Size = new Size(93, 25);
            label9.TabIndex = 6;
            label9.Text = "Language:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 265);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 5;
            label8.Text = "Birthday:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 211);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 4;
            label7.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 156);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 3;
            label6.Text = "Lastname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 106);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 2;
            label5.Text = "Firstname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 56);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // btn_Summit
            // 
            btn_Summit.Location = new Point(538, 729);
            btn_Summit.Name = "btn_Summit";
            btn_Summit.Size = new Size(112, 34);
            btn_Summit.TabIndex = 4;
            btn_Summit.Text = "Summit";
            btn_Summit.UseVisualStyleBackColor = true;
            btn_Summit.Click += btn_Summit_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(380, 729);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(112, 34);
            btn_Clear.TabIndex = 5;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 785);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Summit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "SignupForm";
            Text = "SignupForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox tb_Password;
        private TextBox tb_Username;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btn_Summit;
        private Button btn_Clear;
        private ComboBox cb_Language;
        private DateTimePicker dtp_Birthday;
        private TextBox tb_Phone;
        private TextBox tb_Lastname;
        private TextBox tb_Firstname;
        private TextBox tb_Email;
        private ComboBox cb_Sex;
    }
}