namespace Lab4_24520303_BuiCongDinh.Bai7
{
    partial class AddFood
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_Name = new TextBox();
            tb_Price = new TextBox();
            tb_Address = new TextBox();
            tb_ImageUrl = new TextBox();
            rtb_Description = new RichTextBox();
            btn_Clear = new Button();
            btn_Add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(151, 23);
            label1.Name = "label1";
            label1.Size = new Size(304, 46);
            label1.TabIndex = 1;
            label1.Text = "THÊM MÓN ĂN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 96);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 170);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 3;
            label3.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 249);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 324);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 5;
            label5.Text = "HÌnh ảnh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 398);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 6;
            label6.Text = "Mô tả";
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(207, 93);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(315, 31);
            tb_Name.TabIndex = 7;
            // 
            // tb_Price
            // 
            tb_Price.Location = new Point(207, 167);
            tb_Price.Name = "tb_Price";
            tb_Price.Size = new Size(315, 31);
            tb_Price.TabIndex = 8;
            // 
            // tb_Address
            // 
            tb_Address.Location = new Point(207, 246);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(315, 31);
            tb_Address.TabIndex = 9;
            // 
            // tb_ImageUrl
            // 
            tb_ImageUrl.Location = new Point(207, 321);
            tb_ImageUrl.Name = "tb_ImageUrl";
            tb_ImageUrl.Size = new Size(315, 31);
            tb_ImageUrl.TabIndex = 10;
            // 
            // rtb_Description
            // 
            rtb_Description.Location = new Point(207, 395);
            rtb_Description.Name = "rtb_Description";
            rtb_Description.Size = new Size(315, 144);
            rtb_Description.TabIndex = 11;
            rtb_Description.Text = "";
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(234, 572);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(112, 34);
            btn_Clear.TabIndex = 12;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(410, 572);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(112, 34);
            btn_Add.TabIndex = 13;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 632);
            Controls.Add(btn_Add);
            Controls.Add(btn_Clear);
            Controls.Add(rtb_Description);
            Controls.Add(tb_ImageUrl);
            Controls.Add(tb_Address);
            Controls.Add(tb_Price);
            Controls.Add(tb_Name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddFood";
            Text = "AddFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_Name;
        private TextBox tb_Price;
        private TextBox tb_Address;
        private TextBox tb_ImageUrl;
        private RichTextBox rtb_Description;
        private Button btn_Clear;
        private Button btn_Add;
    }
}