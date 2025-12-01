namespace Lab4_24520303_BuiCongDinh.Bai7
{
    partial class SigninForm
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
            label2 = new Label();
            label3 = new Label();
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            btn_Login = new Button();
            label4 = new Label();
            llb_Signup = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(168, 26);
            label1.Name = "label1";
            label1.Size = new Size(345, 46);
            label1.TabIndex = 2;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 109);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 166);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(185, 106);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(269, 31);
            tb_Username.TabIndex = 5;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(185, 163);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(269, 31);
            tb_Password.TabIndex = 6;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(494, 109);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(136, 85);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 236);
            label4.Name = "label4";
            label4.Size = new Size(226, 25);
            label4.TabIndex = 8;
            label4.Text = "Don't have an account yet?";
            // 
            // llb_Signup
            // 
            llb_Signup.AutoSize = true;
            llb_Signup.Location = new Point(411, 236);
            llb_Signup.Name = "llb_Signup";
            llb_Signup.Size = new Size(68, 25);
            llb_Signup.TabIndex = 9;
            llb_Signup.TabStop = true;
            llb_Signup.Text = "Signup";
            llb_Signup.LinkClicked += llb_Signup_LinkClicked;
            // 
            // SigninForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 297);
            Controls.Add(llb_Signup);
            Controls.Add(label4);
            Controls.Add(btn_Login);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SigninForm";
            Text = "SigninForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_Username;
        private TextBox tb_Password;
        private Button btn_Login;
        private Label label4;
        private LinkLabel llb_Signup;
    }
}