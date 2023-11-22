using MVC_Client.Models;

namespace MVC_Client.Services
{
    public interface INerServices
    {
        public Task PostInstallation(NewInstallationM newInstallation);
        public Task <List<NewInstallationM>> GetInstallations();
    }
}
