using System.Net.Http;

namespace Lab4_24520303_BuiCongDinh.Bai7
{
    public partial class FoodCard : UserControl
    {
        public FoodCard(FoodItem food)
        {
            InitializeComponent();

            lb_FoodName.Text = food.Name;
            lb_Price.Text = food.Price.ToString();
            lb_Address.Text = food.Address;
            lb_Contributor.Text = food.Contributor;

            LoadImageFromUrl(food.ImageUrl);
        }

        public async Task LoadImageFromUrl(string imageUrl)
        {
            try
            {
                var imageBytes = await ApiHelper.httpClient.GetByteArrayAsync(imageUrl);

                using (var stream = new MemoryStream(imageBytes))
                {
                    picB_FoodImage.Image = Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải hình ảnh: " + ex.Message);
            }
        }
    }
}
