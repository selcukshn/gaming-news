namespace Blazor.Services.News
{
    public class NewsService
    {
        private readonly HttpClient Client;
        public NewsService(HttpClient client)
        {
            Client = client;
        }

        public void GetNews()
        {

        }
    }
}