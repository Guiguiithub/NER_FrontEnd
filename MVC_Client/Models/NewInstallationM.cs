using System.ComponentModel.DataAnnotations;

namespace MVC_Client.Models
{
    public class NewInstallationM
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public string Street { get; set; }
        public string No {  get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public int AzimutOrientation { get; set; }
        public int TiltOrientation { get; set; }
        public string EnergyType { get; set; }
        public string IntegrationType { get; set; }
        public string CellsType { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public NewInstallationM() { }
        //set default values so that it doesn't fucked up
        public NewInstallationM(
            string description = null, 
            string imageFile = null, 
            string street = null, 
            string no = null, 
            int postCode = 0, 
            string city = null, 
            double coordinateX = 0.0, 
            double coordinateY = 0.0, 
            int azimutOrientation = 0, 
            int tiltOrientation = 0, 
            string energyType = null, 
            string integrationType = null, 
            string cellsType = null, 
            double length = 0.0, 
            double width = 0.0
            )
        {
            this.Description = description;
            this.Image = imageFile;
            this.Street = street;
            this.No = no;
            this.PostCode = postCode;
            this.City = city;
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
            this.AzimutOrientation = azimutOrientation;
            this.TiltOrientation = tiltOrientation;
            this.EnergyType = energyType;
            this.IntegrationType = integrationType;
            this.CellsType = cellsType;
            this.Length = length;
            this.Width = width;
        }
    }
}
