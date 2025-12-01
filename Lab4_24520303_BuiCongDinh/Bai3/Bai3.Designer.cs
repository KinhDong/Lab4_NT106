using Microsoft.Web.WebView2.WinForms;

namespace Lab4_24520303_BuiCongDinh.Bai3
{
    partial class Bai3
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
            btn_Load = new Button();
            btn_Reload = new Button();
            btn_DownloadFile = new Button();
            btn_DownloadResources = new Button();
            webView = new WebView2();
            btn_ViewSources = new Button();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // tb_WebUrl
            // 
            tb_WebUrl.Location = new Point(163, 29);
            tb_WebUrl.Name = "tb_WebUrl";
            tb_WebUrl.Size = new Size(511, 31);
            tb_WebUrl.TabIndex = 0;
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(35, 27);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(112, 34);
            btn_Load.TabIndex = 1;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // btn_Reload
            // 
            btn_Reload.Location = new Point(689, 27);
            btn_Reload.Name = "btn_Reload";
            btn_Reload.Size = new Size(112, 34);
            btn_Reload.TabIndex = 2;
            btn_Reload.Text = "Reload";
            btn_Reload.UseVisualStyleBackColor = true;
            btn_Reload.Click += btn_Reload_Click;
            // 
            // btn_DownloadFile
            // 
            btn_DownloadFile.Location = new Point(974, 26);
            btn_DownloadFile.Name = "btn_DownloadFile";
            btn_DownloadFile.Size = new Size(112, 34);
            btn_DownloadFile.TabIndex = 3;
            btn_DownloadFile.Text = "Down file";
            btn_DownloadFile.UseVisualStyleBackColor = true;
            btn_DownloadFile.Click += btn_DownloadFile_Click;
            // 
            // btn_DownloadResources
            // 
            btn_DownloadResources.Location = new Point(1110, 27);
            btn_DownloadResources.Name = "btn_DownloadResources";
            btn_DownloadResources.Size = new Size(180, 34);
            btn_DownloadResources.TabIndex = 4;
            btn_DownloadResources.Text = "Down Resources";
            btn_DownloadResources.UseVisualStyleBackColor = true;
            btn_DownloadResources.Click += btn_DownloadResources_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.LightGray;
            webView.Location = new Point(35, 80);
            webView.Name = "webView";
            webView.Size = new Size(1200, 600);
            webView.TabIndex = 5;
            webView.ZoomFactor = 1D;
            // 
            // btn_ViewSources
            // 
            btn_ViewSources.Location = new Point(822, 27);
            btn_ViewSources.Name = "btn_ViewSources";
            btn_ViewSources.Size = new Size(127, 34);
            btn_ViewSources.TabIndex = 6;
            btn_ViewSources.Text = "View Source";
            btn_ViewSources.UseVisualStyleBackColor = true;
            btn_ViewSources.Click += btn_ViewSources_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 708);
            Controls.Add(btn_ViewSources);
            Controls.Add(btn_DownloadResources);
            Controls.Add(btn_DownloadFile);
            Controls.Add(btn_Reload);
            Controls.Add(btn_Load);
            Controls.Add(tb_WebUrl);
            Controls.Add(webView);
            Name = "Bai3";
            Text = "Bai3";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_WebUrl;
        private Button btn_Load;
        private Button btn_Reload;
        private Button btn_DownloadFile;
        private Button btn_DownloadResources;
        private WebView2 webView;
        private Button btn_ViewSources;
    }
}