using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using APIServiceLibrary.DTO;

namespace APIServiceLibrary.Services
{
    public class APIService : IAPIService
    {
        public async Task<ResultsDTO> GetOneDriver()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://randomuser.me/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ResultsDTO driver = new ResultsDTO();

            try
            {
                var response = await client.GetAsync("api/").ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    driver = JsonConvert.DeserializeObject<ResultsDTO>(responseBody) ?? new ResultsDTO();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred during the API request: {ex.Message}");
            }

            return driver ?? new ResultsDTO();
        }
    }
}
