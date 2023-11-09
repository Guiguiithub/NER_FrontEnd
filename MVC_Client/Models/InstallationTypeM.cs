using System.ComponentModel.DataAnnotations;

namespace MVC_Client.Models
{
    public class InstallationTypeM
    {
        [Required]
        public string energyType { get; set; }
        public string integrationType { get; set; }
        public string cellsType { get; set; }

        public InstallationTypeM() { }

        public InstallationTypeM(string energyType, string integrationType, string cellsType)
        {
            this.energyType = energyType;
            this.integrationType = integrationType;
            this.cellsType = cellsType;
        }
    }
}
