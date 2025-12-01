using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lab4_24520303_BuiCongDinh.Bai7
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btn_Summit_Click(object sender, EventArgs e)
        {
            string _username = tb_Username.Text.Trim();
            string _password = tb_Password.Text.Trim();
            string _email = tb_Email.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password) || string.IsNullOrEmpty(_email))
                {
                    throw new ArgumentException("Username, Password và Email không được để trống!");
                }

                var userData = new
                {
                    username = _username,
                    email = _email,
                    password = _password,
                    first_name = tb_Firstname.Text.Trim() ?? "",
                    last_name = tb_Lastname.Text.Trim() ?? "",
                    sex = cb_Sex.SelectedIndex > -1 ? cb_Sex.SelectedIndex : 0,
                    birthday = dtp_Birthday.Value.ToString("yyyy-MM-dd"),
                    language = cb_Language.SelectedIndex > -1 ? cb_Language.Text : "",
                    phone = tb_Phone.Text.Trim() ?? ""
                };

                var json = JsonConvert.SerializeObject(userData);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = ApiHelper.httpClient.PostAsync(ApiHelper.BaseUrl + "/api/v1/user/signup", content);

                if (!response.Result.IsSuccessStatusCode)
                {
                    throw new Exception("Đăng ký thất bại!");
                }
                else
                {
                    MessageBox.Show("Đăng ký thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SigninForm signinForm = new();
                    signinForm.Show();
                    this.Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Username.Clear();
            tb_Password.Clear();
            tb_Email.Clear();
            tb_Firstname.Clear();
            tb_Lastname.Clear();
            cb_Language.SelectedIndex = -1;
            cb_Sex.SelectedIndex = -1;
            tb_Phone.Clear();
            dtp_Birthday.Value = DateTime.Now;
        }
    }
}
