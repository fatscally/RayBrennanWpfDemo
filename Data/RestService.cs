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

        JsonSerializerOptions serializerOptions;


        public RestService()
        {

            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,

                WriteIndented = true
            };
        }


        internal async Task<Price> GetLatestPriceAsync()
        {

            Price price = new();

            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                using HttpClient client = new();

                
                HttpResponseMessage response = new();
                
                //the button is disabled here...
                response = await client.GetAsync(uri).ConfigureAwait(false);


                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    price = JsonSerializer.Deserialize<Price>(content, serializerOptions);

                }



            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return price;
        }




    }
}

