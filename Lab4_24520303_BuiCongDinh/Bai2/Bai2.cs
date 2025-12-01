using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_24520303_BuiCongDinh.Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private async void btn_Download_Click(object sender, EventArgs e)
        {
            string url = tb_WebUrl.Text.Trim();
            string downloadName = tb_DownloadName.Text.Trim();

            try
            {
                await DownloadFile(url, downloadName);

                await ReadFile($@"..\..\..\Bai2\Downloads\{downloadName}.html");
            }
            
            catch { }
        }

        private async Task DownloadFile(string url, string downloadName)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    throw new Exception("Vui lòng nhập URL hợp lệ!");
                }

                if (string.IsNullOrEmpty(downloadName))
                {
                    throw new Exception("Vui lòng nhập tên file hợp lệ!");
                }

                using var httpClient = new HttpClient();
                using var response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                using var content = await response.Content.ReadAsStreamAsync();
                using var fs = new FileStream($@"..\..\..\Bai2\Downloads\{downloadName}.html", FileMode.Create);
                await content.CopyToAsync(fs);

                MessageBox.Show("Tải file thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ReadFile(string path)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    throw new Exception("Vui lòng nhập đường dẫn file hợp lệ!");
                }

                using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                using var sr = new StreamReader(fs);
                string content = await sr.ReadToEndAsync();
                rtb_Content.Text = content;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
