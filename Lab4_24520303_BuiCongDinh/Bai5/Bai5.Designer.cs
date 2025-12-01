namespace Lab4_24520303_BuiCongDinh.Bai5
{
    partial class Bai5
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
            label2 = new Label();
            label3 = new Label();
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            rtb_Result = new RichTextBox();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 38);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 100);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(197, 35);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(330, 31);
            tb_Username.TabIndex = 4;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(197, 97);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(330, 31);
            tb_Password.TabIndex = 5;
            // 
            // rtb_Result
            // 
            rtb_Result.Location = new Point(55, 177);
            rtb_Result.Name = "rtb_Result";
            rtb_Result.ReadOnly = true;
            rtb_Result.Size = new Size(689, 238);
            rtb_Result.TabIndex = 6;
            rtb_Result.Text = "";
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(576, 35);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(168, 93);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Login);
            Controls.Add(rtb_Result);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox tb_Username;
        private TextBox tb_Password;
        private RichTextBox rtb_Result;
        private Button btn_Login;
    }
}