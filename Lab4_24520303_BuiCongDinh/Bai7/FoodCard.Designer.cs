namespace Lab4_24520303_BuiCongDinh.Bai7
{
    partial class FoodCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picB_FoodImage = new PictureBox();
            lb_FoodName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lb_Price = new Label();
            lb_Address = new Label();
            lb_Contributor = new Label();
            ((System.ComponentModel.ISupportInitialize)picB_FoodImage).BeginInit();
            SuspendLayout();
            // 
            // picB_FoodImage
            // 
            picB_FoodImage.Location = new Point(14, 13);
            picB_FoodImage.Name = "picB_FoodImage";
            picB_FoodImage.Size = new Size(213, 193);
            picB_FoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picB_FoodImage.TabIndex = 0;
            picB_FoodImage.TabStop = false;
            // 
            // lb_FoodName
            // 
            lb_FoodName.AutoSize = true;
            lb_FoodName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_FoodName.ForeColor = Color.FromArgb(255, 128, 0);
            lb_FoodName.Location = new Point(271, 13);
            lb_FoodName.Name = "lb_FoodName";
            lb_FoodName.Size = new Size(100, 32);
            lb_FoodName.TabIndex = 1;
            lb_FoodName.Text = "Rau má";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 78);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 2;
            label2.Text = "Giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 125);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 169);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 4;
            label4.Text = "Người đóng góp:";
            // 
            // lb_Price
            // 
            lb_Price.AutoSize = true;
            lb_Price.Location = new Point(445, 78);
            lb_Price.Name = "lb_Price";
            lb_Price.Size = new Size(32, 25);
            lb_Price.TabIndex = 5;
            lb_Price.Text = "36";
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Location = new Point(445, 125);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(98, 25);
            lb_Address.TabIndex = 6;
            lb_Address.Text = "Thanh Hóa";
            // 
            // lb_Contributor
            // 
            lb_Contributor.AutoSize = true;
            lb_Contributor.Location = new Point(445, 169);
            lb_Contributor.Name = "lb_Contributor";
            lb_Contributor.Size = new Size(95, 25);
            lb_Contributor.TabIndex = 7;
            lb_Contributor.Text = "Raumanist";
            // 
            // FoodCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lb_Contributor);
            Controls.Add(lb_Address);
            Controls.Add(lb_Price);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lb_FoodName);
            Controls.Add(picB_FoodImage);
            Name = "FoodCard";
            Size = new Size(670, 224);
            ((System.ComponentModel.ISupportInitialize)picB_FoodImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picB_FoodImage;
        private Label lb_FoodName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lb_Price;
        private Label lb_Address;
        private Label lb_Contributor;
    }
}
