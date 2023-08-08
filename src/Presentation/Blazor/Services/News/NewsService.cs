
using Blazor.Models;
using Newtonsoft.Json;

namespace Blazor.Services.News
{
    public class NewsService
    {
        private readonly HttpClient Client;
        public NewsService(HttpClient client)
        {
            Client = client;
        }

        public async Task<List<GetNewsModel>> GetNews()
        {
            var response = await Client.GetAsync("/api/news");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<GetNewsModel>>(await response.Content.ReadAsStringAsync());
            }
            return new List<GetNewsModel>();
        }
    }
}