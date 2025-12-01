using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_24520303_BuiCongDinh.Bai6
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text.Trim();
            string password = tb_Password.Text.Trim();
            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }

                using var httpClient = new HttpClient();

                // Get the access token
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };

                string url = "https://nt106.uitiot.vn/auth/token";
                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                var responseObject = JObject.Parse(responseString);

                if (!response.IsSuccessStatusCode)
                {
                    var detail = responseObject["detail"].ToString();
                    throw new Exception($"Đăng nhập thất bại: {detail}");
                }

                var tokenType = responseObject["token_type"].ToString();
                var accessToken = responseObject["access_token"].ToString();

                // Use the access token to authenticate a GET request
                httpClient.DefaultRequestHeaders.Authorization = new
               System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                var getUserResponse = await httpClient.GetAsync(getUserUrl);
                var getUserResponseString = await
               getUserResponse.Content.ReadAsStringAsync();

                rtb_Result.Text = getUserResponseString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
