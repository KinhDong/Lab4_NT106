namespace Lab4_24520303_BuiCongDinh.Bai2
{
    partial class Bai2
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
            tb_WebUrl = new TextBox();
            lb_HtmlFile = new Label();
            rtb_Content = new RichTextBox();
            btn_Download = new Button();
            tb_DownloadName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tb_WebUrl
            // 
            tb_WebUrl.Location = new Point(160, 24);
            tb_WebUrl.Name = "tb_WebUrl";
            tb_WebUrl.ScrollBars = ScrollBars.Horizontal;
            tb_WebUrl.Size = new Size(604, 31);
            tb_WebUrl.TabIndex = 0;
            // 
            // lb_HtmlFile
            // 
            lb_HtmlFile.AutoSize = true;
            lb_HtmlFile.Location = new Point(37, 187);
            lb_HtmlFile.Name = "lb_HtmlFile";
            lb_HtmlFile.Size = new Size(82, 25);
            lb_HtmlFile.TabIndex = 1;
            lb_HtmlFile.Text = "Filename";
            // 
            // rtb_Content
            // 
            rtb_Content.Location = new Point(37, 227);
            rtb_Content.Name = "rtb_Content";
            rtb_Content.Size = new Size(727, 307);
            rtb_Content.TabIndex = 2;
            rtb_Content.Text = "";
            // 
            // btn_Download
            // 
            btn_Download.Location = new Point(652, 92);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(112, 34);
            btn_Download.TabIndex = 3;
            btn_Download.Text = "Download";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += btn_Download_Click;
            // 
            // tb_DownloadName
            // 
            tb_DownloadName.Location = new Point(160, 94);
            tb_DownloadName.Name = "tb_DownloadName";
            tb_DownloadName.ScrollBars = ScrollBars.Horizontal;
            tb_DownloadName.Size = new Size(251, 31);
            tb_DownloadName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 97);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 5;
            label1.Text = "Lưu thành:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 97);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 6;
            label2.Text = ".html";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 27);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 7;
            label3.Text = "Đường dẫn:";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_DownloadName);
            Controls.Add(btn_Download);
            Controls.Add(rtb_Content);
            Controls.Add(lb_HtmlFile);
            Controls.Add(tb_WebUrl);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_WebUrl;
        private Label lb_HtmlFile;
        private RichTextBox rtb_Content;
        private Button btn_Download;
        private TextBox tb_DownloadName;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}