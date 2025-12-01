namespace Lab4_24520303_BuiCongDinh.Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private async void btn_Load_Click(object sender, EventArgs e)
        {
            string url = tb_WebUrl.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    throw new Exception("Vui lòng nhập URL hợp lệ!");
                }

                await webView.EnsureCoreWebView2Async();
                webView.CoreWebView2.Navigate(url);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Reload_Click(object sender, EventArgs e)
        {
            try
            {
                if (webView.CoreWebView2 == null)
                {
                    await webView.EnsureCoreWebView2Async(null);
                }

                webView.Reload();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_ViewSources_Click(object sender, EventArgs e)
        {
            string url = tb_WebUrl.Text.Trim();

            try
            {
                if (webView.CoreWebView2 == null)
                {
                    await webView.EnsureCoreWebView2Async(null);
                }

                string webSource = await webView.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");

                WebSources webSourcesForm = new WebSources(url, webSource);
                webSourcesForm.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_DownloadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (webView.CoreWebView2 == null)
                {
                    await webView.EnsureCoreWebView2Async(null);
                }

                string htmlContent = await webView.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");

                using var sfd = new SaveFileDialog();
                sfd.Filter = "HTML Files (*.html)|*.html|All Files (*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;
                sfd.Title = "Lưu file";
                sfd.OverwritePrompt = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, htmlContent);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_DownloadResources_Click(object sender, EventArgs e)
        {
            try
            {
                if (webView.CoreWebView2 == null)
                {
                    await webView.EnsureCoreWebView2Async(null);
                }

                using var fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                string folderPath = fbd.SelectedPath;


                // JavaScript lấy tất cả src của ảnh
                string script = @"
                    (function() {
                        let imgs = Array.from(document.images).map(i => i.src);
                        return JSON.stringify(imgs);
                    })();
                ";

                string result = await webView.CoreWebView2.ExecuteScriptAsync(script);
                result = result.Trim('"');
                result = result.Replace("\\\"", "\"");
                var imgUrls = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(result);

                using var httpClient = new HttpClient();
                int count = 1;
                foreach (var imgUrl in imgUrls)
                {
                    byte[] data = await httpClient.GetByteArrayAsync(imgUrl);

                    string ext = Path.GetExtension(imgUrl);
                    if (string.IsNullOrWhiteSpace(ext))
                        ext = ".jpg";

                    string filePath = Path.Combine(folderPath, $"image_{count}{ext}");

                    await File.WriteAllBytesAsync(filePath, data);
                    count++;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
