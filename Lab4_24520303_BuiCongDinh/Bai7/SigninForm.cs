using Newtonsoft.Json.Linq;

namespace Lab4_24520303_BuiCongDinh.Bai7
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
        }

        private void llb_Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new();
            signupForm.Show();
            this.Hide();
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

                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };

                var response = await ApiHelper.httpClient.PostAsync(ApiHelper.BaseUrl + "/auth/token", content);
                var responseString = await response.Content.ReadAsStringAsync();

                var responseObject = JObject.Parse(responseString);

                if (!response.IsSuccessStatusCode)
                {
                    var detail = responseObject["detail"].ToString();
                    throw new Exception($"Đăng nhập thất bại: {detail}");
                }

                ApiHelper.username = username;

                // Lưu token
                ApiHelper.httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", responseObject["access_token"].ToString());

                Bai7 menu = new();
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
