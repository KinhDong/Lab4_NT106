using Microsoft.Web.WebView2.WinForms;

namespace Lab4_24520303_BuiCongDinh.Bai4
{
    partial class Bai4
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
            btn_Back = new Button();
            btn_Forward = new Button();
            webView = new WebView2();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(27, 31);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(54, 34);
            btn_Back.TabIndex = 0;
            btn_Back.Text = "<-";
            btn_Back.UseVisualStyleBackColor = true;
            // 
            // btn_Forward
            // 
            btn_Forward.Location = new Point(103, 31);
            btn_Forward.Name = "btn_Forward";
            btn_Forward.Size = new Size(56, 34);
            btn_Forward.TabIndex = 1;
            btn_Forward.Text = "->";
            btn_Forward.UseVisualStyleBackColor = true;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(50, 80);
            webView.Name = "webView";
            webView.Size = new Size(1200, 600);
            webView.TabIndex = 2;
            webView.ZoomFactor = 1D;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 703);
            Controls.Add(btn_Forward);
            Controls.Add(btn_Back);
            Controls.Add(webView);
            Name = "Bai4";
            Text = "Bai4";
            Load += Bai4_Load;
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Back;
        private Button btn_Forward;
        private WebView2 webView;
    }
}