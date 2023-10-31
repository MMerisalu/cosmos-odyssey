namespace BlazorWebApp.Services
{
    public class MVCBaseService
    {
        private readonly HttpClient _httpClient;
        public MVCBaseService(HttpClient client)
        {
            _httpClient = client;
        }
        public string GetBaseUrl() => _httpClient.BaseAddress.ToString();
        public HttpClient Client { get => _httpClient; }
    }
}
