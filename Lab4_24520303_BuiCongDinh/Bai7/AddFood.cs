using Newtonsoft.Json;

namespace Lab4_24520303_BuiCongDinh.Bai7
{
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_Name.Text.Trim();
                int price = int.Parse(tb_Price.Text.Trim());
                string address = tb_Address.Text.Trim();
                string imageUrl = tb_ImageUrl.Text.Trim();
                string description = rtb_Description.Text.Trim();

                var foodData = new
                {
                    ten_mon_an = name,
                    gia = price,
                    mo_ta = description,
                    dia_chi = address,
                    hinh_anh = imageUrl
                };

                var json = JsonConvert.SerializeObject(foodData);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await ApiHelper.httpClient.PostAsync(ApiHelper.BaseUrl + "/api/v1/monan/add", content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Thêm món ăn thất bại! \n" + await response.Content.ReadAsStringAsync());
                }

                MessageBox.Show("Thêm món ăn thành công!");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            tb_Address.Clear();
            tb_ImageUrl.Clear();
            tb_Price.Clear();
            rtb_Description.Clear();
        }
    }
}
