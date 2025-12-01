using System.Drawing.Printing;

namespace Lab4_24520303_BuiCongDinh.Bai7
{
    public static class ApiHelper
    {
        public static string BaseUrl = "https://nt106.uitiot.vn";

        public static HttpClient httpClient = new();
        public static string username {  get; set; }
    }
}
