using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Lab4_24520303_BuiCongDinh.Bai7
{
    public partial class Bai7 : Form
    {
        private List<FoodItem> foods { get; set; }
        private string _contributor { get; set; }
        public Bai7()
        {
            InitializeComponent();

            lb_WelcomBitch.Text += ApiHelper.username + '!';

            foods = new();

            _contributor = "all";

            cb_Page.SelectedIndex = 0;
            cb_PageSize.SelectedIndex = 0;
        }

        private async Task GetAPageOfFoods(int _page, int _pageSize)
        {
            try
            {
                foods.Clear();
                flpn_FoodList.Controls.Clear();

                var pageData = new
                {
                    current = _page,
                    pageSize = _pageSize
                };

                var json = JsonConvert.SerializeObject(pageData);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await ApiHelper.httpClient.PostAsync(ApiHelper.BaseUrl + "/api/v1/monan/" + _contributor, content);

                var responseData = await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(responseData);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Lấy dữ liệu thất bại! \n" + jObject.ToString());
                }

                var dataArray = jObject["data"] as JArray;

                if (dataArray == null)
                {
                    throw new Exception("Dữ liệu trống!");
                }

                foreach (var item in dataArray)
                {
                    var foodItem = new FoodItem
                    {
                        Name = item["ten_mon_an"].ToString(),
                        Price = (int)item["gia"],
                        Address = item["dia_chi"].ToString(),
                        Contributor = item["nguoi_dong_gop"].ToString(),
                        ImageUrl = item["hinh_anh"].ToString()
                    };
                    foods.Add(foodItem);

                    // Thêm lên giao diện
                    var foodCard = new FoodCard(foodItem);
                    flpn_FoodList.Controls.Add(foodCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cb_PageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetAPageOfFoods(cb_Page.SelectedIndex + 1, cb_PageSize.SelectedIndex + 1);
        }

        private async void cb_Page_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetAPageOfFoods(cb_Page.SelectedIndex + 1, cb_PageSize.SelectedIndex + 1);
        }

        private async void btn_AddFood_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood();
            addFood.Show();
        }

        private async void btn_AllFoods_Click(object sender, EventArgs e)
        {
            btn_AllFoods.BackColor = SystemColors.ButtonHighlight;
            btn_MyFoods.BackColor = SystemColors.ControlLight;
            _contributor = "all";
            await GetAPageOfFoods(cb_Page.SelectedIndex + 1, cb_PageSize.SelectedIndex + 1);
        }

        private async void btn_MyFoods_Click(object sender, EventArgs e)
        {
            btn_MyFoods.BackColor = SystemColors.ButtonHighlight;
            btn_AllFoods.BackColor = SystemColors.ControlLight;
            _contributor = "my-dishes";
            await GetAPageOfFoods(cb_Page.SelectedIndex + 1, cb_PageSize.SelectedIndex + 1);
        }

        private void btn_RandomFood_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int ran = random.Next(0, foods.Count - 1);
            RandomFood randomFood = new RandomFood(foods[ran]);
            randomFood.Show();
        }

        private void llb_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ApiHelper.httpClient.DefaultRequestHeaders.Remove("Authorization");
            SigninForm signinForm = new();
            signinForm.Show();
            this.Close();
        }
    }
}
