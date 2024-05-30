using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GetPostAppGUI
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void getbtn_Click(object sender, EventArgs e)
        {
            string response = await GetProducts();
            txtGetResults.Text = response;
        }

        private async void postbtn_Click(object sender, EventArgs e)
        {
            string postData = txtPostData.Text; // Data to post
            string response = await PostProduct(postData);
            lblPostStatus.Text = response;
            // Refresh the product list after posting a new product
            string getResponse = await GetProducts();
            txtGetResults.Text = getResponse;
        }

        private async Task<string> GetProducts()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost/api/index.php?table=products");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                return $"Request error: {e.Message}";
            }
        }

        private async Task<string> PostProduct(string productData)
        {
            try
            {
                var dataParts = productData.Split(',');
                if (dataParts.Length != 2)
                {
                    return "Invalid input format. Use 'name,price'.";
                }

                string name = dataParts[0].Trim();
                string price = dataParts[1].Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
                {
                    return "Name and price cannot be empty.";
                }

                var product = new
                {
                    table = "products",
                    name = name,
                    price = price
                };

                string json = JsonConvert.SerializeObject(product);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("http://localhost/api/index.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (Exception e)
            {
                return $"Request error: {e.Message}";
            }
        }
    }
}
