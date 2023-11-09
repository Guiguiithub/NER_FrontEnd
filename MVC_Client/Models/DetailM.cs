namespace MVC_Client.Models
{
    public class DetailM
    {
        public string description { get; set; }
        public IFormFile imageFile { get; set; }

        public DetailM() { }

        public DetailM(string description, IFormFile imageFile)
        {
            this.description = description;
            this.imageFile = imageFile;
        }

    }
}
