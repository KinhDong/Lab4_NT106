namespace Lab4_24520303_BuiCongDinh.Bai6
{
    partial class Bai6
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
            btn_Login = new Button();
            rtb_Result = new RichTextBox();
            tb_Password = new TextBox();
            tb_Username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(567, 34);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(168, 93);
            btn_Login.TabIndex = 13;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // rtb_Result
            // 
            rtb_Result.Location = new Point(46, 176);
            rtb_Result.Name = "rtb_Result";
            rtb_Result.ReadOnly = true;
            rtb_Result.Size = new Size(689, 238);
            rtb_Result.TabIndex = 12;
            rtb_Result.Text = "";
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(188, 96);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(330, 31);
            tb_Password.TabIndex = 11;
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(188, 34);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(330, 31);
            tb_Username.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 99);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 37);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 448);
            Controls.Add(btn_Login);
            Controls.Add(rtb_Result);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private RichTextBox rtb_Result;
        private TextBox tb_Password;
        private TextBox tb_Username;
        private Label label3;
        private Label label2;
    }
}