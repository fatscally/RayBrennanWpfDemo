using NoFrixionWpf.Models;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace NoFrixionWpf.Data
{

    internal class RestService 
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;
        private Price? Price;

        public RestService()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,

                WriteIndented = true
            };
        }


        internal async Task<Price> GetLatestPriceAsync()
        {
            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
   
                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    Price = JsonSerializer.Deserialize<Price>(content, serializerOptions);
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Price;
        }




    }
}

