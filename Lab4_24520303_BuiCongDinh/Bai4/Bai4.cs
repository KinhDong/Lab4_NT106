namespace Lab4_24520303_BuiCongDinh.Bai4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private async void Bai4_Load(object sender, EventArgs e)
        {
            string url = "https://betacinemas.vn/phim.htm";

            try
            {
                await webView.EnsureCoreWebView2Async();
                webView.CoreWebView2.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
