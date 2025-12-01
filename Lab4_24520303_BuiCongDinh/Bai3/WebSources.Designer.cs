namespace Lab4_24520303_BuiCongDinh.Bai3
{
    partial class WebSources
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
            rtb_Source = new RichTextBox();
            tb_WebUrl = new TextBox();
            SuspendLayout();
            // 
            // rtb_Source
            // 
            rtb_Source.Location = new Point(24, 50);
            rtb_Source.Name = "rtb_Source";
            rtb_Source.ReadOnly = true;
            rtb_Source.Size = new Size(756, 378);
            rtb_Source.TabIndex = 0;
            rtb_Source.Text = "";
            // 
            // tb_WebUrl
            // 
            tb_WebUrl.Location = new Point(24, 12);
            tb_WebUrl.Name = "tb_WebUrl";
            tb_WebUrl.ReadOnly = true;
            tb_WebUrl.ScrollBars = ScrollBars.Horizontal;
            tb_WebUrl.Size = new Size(756, 31);
            tb_WebUrl.TabIndex = 1;
            // 
            // WebSources
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_WebUrl);
            Controls.Add(rtb_Source);
            Name = "WebSources";
            Text = "WebSources";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_Source;
        private TextBox tb_WebUrl;
    }
}