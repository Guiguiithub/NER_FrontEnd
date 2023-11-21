using MVC_Client.Models;

namespace MVC_Client.Services
{
    public class NerServices : INerServices
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public NerServices(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseUrl = configuration["WebAPI:BaseUrl"];
        }

        public async Task PostInstallation(NewInstallationM newInstallation)
        {
            var response = await _httpClient.PostAsJsonAsync(_baseUrl + "/api/Installations", newInstallation);
        }
    }
}
