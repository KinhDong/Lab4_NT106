namespace Lab4_24520303_BuiCongDinh.Bai7
{
    partial class Bai7
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
            btn_RandomFood = new Button();
            btn_AddFood = new Button();
            flpn_FoodList = new FlowLayoutPanel();
            btn_AllFoods = new Button();
            btn_MyFoods = new Button();
            label3 = new Label();
            cb_PageSize = new ComboBox();
            label2 = new Label();
            cb_Page = new ComboBox();
            lb_WelcomBitch = new Label();
            llb_Logout = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 46);
            label1.TabIndex = 0;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // btn_RandomFood
            // 
            btn_RandomFood.BackColor = Color.FromArgb(255, 224, 192);
            btn_RandomFood.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RandomFood.Location = new Point(422, 72);
            btn_RandomFood.Name = "btn_RandomFood";
            btn_RandomFood.Size = new Size(151, 71);
            btn_RandomFood.TabIndex = 1;
            btn_RandomFood.Text = "Ăn gì giờ?";
            btn_RandomFood.UseVisualStyleBackColor = false;
            btn_RandomFood.Click += btn_RandomFood_Click;
            // 
            // btn_AddFood
            // 
            btn_AddFood.BackColor = Color.Gold;
            btn_AddFood.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddFood.Location = new Point(610, 72);
            btn_AddFood.Name = "btn_AddFood";
            btn_AddFood.Size = new Size(148, 71);
            btn_AddFood.TabIndex = 2;
            btn_AddFood.Text = "Thêm món ăn";
            btn_AddFood.UseVisualStyleBackColor = false;
            btn_AddFood.Click += btn_AddFood_Click;
            // 
            // flpn_FoodList
            // 
            flpn_FoodList.AutoScroll = true;
            flpn_FoodList.BackColor = SystemColors.ButtonHighlight;
            flpn_FoodList.BorderStyle = BorderStyle.FixedSingle;
            flpn_FoodList.FlowDirection = FlowDirection.TopDown;
            flpn_FoodList.Location = new Point(57, 188);
            flpn_FoodList.Name = "flpn_FoodList";
            flpn_FoodList.Size = new Size(701, 573);
            flpn_FoodList.TabIndex = 3;
            flpn_FoodList.WrapContents = false;
            // 
            // btn_AllFoods
            // 
            btn_AllFoods.BackColor = SystemColors.ButtonHighlight;
            btn_AllFoods.Location = new Point(57, 157);
            btn_AllFoods.Name = "btn_AllFoods";
            btn_AllFoods.Size = new Size(112, 34);
            btn_AllFoods.TabIndex = 4;
            btn_AllFoods.Text = "Chung";
            btn_AllFoods.UseVisualStyleBackColor = false;
            btn_AllFoods.Click += btn_AllFoods_Click;
            // 
            // btn_MyFoods
            // 
            btn_MyFoods.BackColor = SystemColors.ControlLight;
            btn_MyFoods.Location = new Point(175, 157);
            btn_MyFoods.Name = "btn_MyFoods";
            btn_MyFoods.Size = new Size(143, 34);
            btn_MyFoods.TabIndex = 5;
            btn_MyFoods.Text = "Tôi đóng góp";
            btn_MyFoods.UseVisualStyleBackColor = false;
            btn_MyFoods.Click += btn_MyFoods_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(597, 792);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 7;
            label3.Text = "Page size:";
            // 
            // cb_PageSize
            // 
            cb_PageSize.FormattingEnabled = true;
            cb_PageSize.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cb_PageSize.Location = new Point(691, 789);
            cb_PageSize.Name = "cb_PageSize";
            cb_PageSize.Size = new Size(67, 33);
            cb_PageSize.TabIndex = 8;
            cb_PageSize.SelectedIndexChanged += cb_PageSize_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 792);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 9;
            label2.Text = "Page:";
            // 
            // cb_Page
            // 
            cb_Page.FormattingEnabled = true;
            cb_Page.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cb_Page.Location = new Point(476, 789);
            cb_Page.Name = "cb_Page";
            cb_Page.Size = new Size(70, 33);
            cb_Page.TabIndex = 10;
            cb_Page.SelectedIndexChanged += cb_Page_SelectedIndexChanged;
            // 
            // lb_WelcomBitch
            // 
            lb_WelcomBitch.AutoSize = true;
            lb_WelcomBitch.Location = new Point(22, 797);
            lb_WelcomBitch.Name = "lb_WelcomBitch";
            lb_WelcomBitch.Size = new Size(85, 25);
            lb_WelcomBitch.TabIndex = 11;
            lb_WelcomBitch.Text = "Welcom, ";
            // 
            // llb_Logout
            // 
            llb_Logout.AutoSize = true;
            llb_Logout.Location = new Point(228, 797);
            llb_Logout.Name = "llb_Logout";
            llb_Logout.Size = new Size(69, 25);
            llb_Logout.TabIndex = 12;
            llb_Logout.TabStop = true;
            llb_Logout.Text = "Logout";
            llb_Logout.LinkClicked += llb_Logout_LinkClicked;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 854);
            Controls.Add(llb_Logout);
            Controls.Add(lb_WelcomBitch);
            Controls.Add(cb_Page);
            Controls.Add(label2);
            Controls.Add(cb_PageSize);
            Controls.Add(label3);
            Controls.Add(btn_MyFoods);
            Controls.Add(btn_AllFoods);
            Controls.Add(flpn_FoodList);
            Controls.Add(btn_AddFood);
            Controls.Add(btn_RandomFood);
            Controls.Add(label1);
            Name = "Bai7";
            Text = "Bai7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_RandomFood;
        private Button btn_AddFood;
        private FlowLayoutPanel flpn_FoodList;
        private Button btn_AllFoods;
        private Button btn_MyFoods;
        private Label label3;
        private ComboBox cb_PageSize;
        private Label label2;
        private ComboBox cb_Page;
        private Label lb_WelcomBitch;
        private LinkLabel llb_Logout;
    }
}