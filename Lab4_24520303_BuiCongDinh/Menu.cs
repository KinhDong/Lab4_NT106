namespace Lab4_24520303_BuiCongDinh
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            Bai1.Bai1 bai1 = new();
            bai1.Show();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            Bai2.Bai2 bai2 = new();
            bai2.Show();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            Bai3.Bai3 bai3 = new();
            bai3.Show();
        }

        private void btn_Bai4_Click(object sender, EventArgs e)
        {
            Bai4.Bai4 bai4 = new();
            bai4.Show();
        }

        private void btn_Bai5_Click(object sender, EventArgs e)
        {
            Bai5.Bai5 bai5 = new();
            bai5.Show();
        }

        private void btn_Bai6_Click(object sender, EventArgs e)
        {
            Bai6.Bai6 bai6 = new();
            bai6.Show();
        }

        private void btn_Bai7_Click(object sender, EventArgs e)
        {
            Bai7.SigninForm bai7 = new();
            bai7.Show();
        }
    }
}
