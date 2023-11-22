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

        public async Task<List<NewInstallationM>> GetInstallations()
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/api/Installations");
            if(response.IsSuccessStatusCode)
            {
                var installations = await response.Content.ReadFromJsonAsync<List<NewInstallationM>>();
                return installations;
            }

            return null;
        }
    }
}
