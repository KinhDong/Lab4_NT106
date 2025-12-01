namespace Lab4_24520303_BuiCongDinh.Bai1
{
    partial class Bai1
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
            btn_GetHtml = new Button();
            rtb_Content = new RichTextBox();
            SuspendLayout();
            // 
            // tb_WebUrl
            // 
            tb_WebUrl.Location = new Point(28, 24);
            tb_WebUrl.Name = "tb_WebUrl";
            tb_WebUrl.ScrollBars = ScrollBars.Horizontal;
            tb_WebUrl.Size = new Size(604, 31);
            tb_WebUrl.TabIndex = 0;
            // 
            // btn_GetHtml
            // 
            btn_GetHtml.Location = new Point(658, 22);
            btn_GetHtml.Name = "btn_GetHtml";
            btn_GetHtml.Size = new Size(112, 34);
            btn_GetHtml.TabIndex = 1;
            btn_GetHtml.Text = "GET";
            btn_GetHtml.UseVisualStyleBackColor = true;
            btn_GetHtml.Click += btn_GetHtml_Click;
            // 
            // rtb_Content
            // 
            rtb_Content.Location = new Point(28, 84);
            rtb_Content.Name = "rtb_Content";
            rtb_Content.Size = new Size(742, 336);
            rtb_Content.TabIndex = 2;
            rtb_Content.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_Content);
            Controls.Add(btn_GetHtml);
            Controls.Add(tb_WebUrl);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_WebUrl;
        private Button btn_GetHtml;
        private RichTextBox rtb_Content;
    }
}