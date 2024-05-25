using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class Ex6 : Form
    {
        Uri infoURL = new Uri("https://nt106.uitiot.vn/api/v1/user/me");
        Uri tokenURL = new Uri("https://nt106.uitiot.vn/auth/token");
        String result = "";
        public Ex6()
        {
            url.Text = "URL : https://nt106.uitiot.vn/api/v1/user/me";
            InitializeComponent();
        }
        
        public async void Get(Object sender, EventArgs e)
        {
            String username = usernameInput.Text.ToString();    
            String password = passwordInput.Text.ToString();
            AuthAndGetInfo(username, password);
            userInfo.Text = result;
        }

        public async Task AuthAndGetInfo(String username, String password)
        {
            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };
                var response = await client.PostAsync(tokenURL, content);
                var responseString = await response.Content.ReadAsStringAsync();
                var responseObject = JObject.Parse(responseString);
                if (!response.IsSuccessStatusCode)
                {
                    var detail = responseObject["detail"].ToString();
                    Console.WriteLine($"Detail: {detail}");
                    return;
                }
                var tokenType = responseObject["token_type"].ToString();
                var accessToken = responseObject["access_token"].ToString();
                client.DefaultRequestHeaders.Authorization = new
                System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                var getUserResponse = await client.GetAsync(infoURL);
                var getUserResponseString = await
                getUserResponse.Content.ReadAsStringAsync();
                result = getUserResponseString + "\n" + $"Auth Token : {accessToken}";
            }
        }
    }
}
