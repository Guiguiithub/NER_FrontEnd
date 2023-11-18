namespace MVC_Client.Models
{
    public class NewInstallationM
    {
        public string description { get; set; }
        public IFormFile formFile { get; set; }
        public string street { get; set; }
        public string no {  get; set; }
        public int postCode { get; set; }
        public string city { get; set; }
        public double coordinateX { get; set; }
        public double coordinateY { get; set; }
        public int azimutOrientation { get; set; }
        public int tiltOrientation { get; set; }
        public string energyType { get; set; }
        public string integrationType { get; set; }
        public string cellsType { get; set; }
        public double length { get; set; }
        public double width { get; set; }

        public NewInstallationM() { }
        //set default values so that it doesn't fucked up
        public NewInstallationM(
            string description = null, 
            IFormFile formFile = null, 
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
            this.description = description;
            this.formFile = formFile;
            this.street = street;
            this.no = no;
            this.postCode = postCode;
            this.city = city;
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.azimutOrientation = azimutOrientation;
            this.tiltOrientation = tiltOrientation;
            this.energyType = energyType;
            this.integrationType = integrationType;
            this.cellsType = cellsType;
            this.length = length;
            this.width = width;
        }
    }
}
