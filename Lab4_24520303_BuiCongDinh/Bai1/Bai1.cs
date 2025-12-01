namespace Lab4_24520303_BuiCongDinh.Bai1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private async void btn_GetHtml_Click(object sender, EventArgs e)
        {
            rtb_Content.Clear();

            try
            {
                string url = tb_WebUrl.Text.Trim();
                if (string.IsNullOrEmpty(url))
                {
                    throw new Exception("Vui lòng nhập URL hợp lệ.");
                }

                using HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; MyApp/1.0)");

                using HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                rtb_Content.Text = await response.Content.ReadAsStringAsync();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
