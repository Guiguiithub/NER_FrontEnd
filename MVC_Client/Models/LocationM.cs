using System.ComponentModel.DataAnnotations;

namespace MVC_Client.Models
{
    public class LocationM
    {
        [Required]
        public string Street { get; set; }
        public string No {  get; set; }
        public int Postcode { get; set; }
        public string City { get; set; }

        public IFormFile formFile { get; set; }

        public LocationM() { }

        public LocationM(string street, string no, int postcode, string city)
        {
            Street = street;
            No = no;
            Postcode = postcode;
            City = city;
            this.formFile = formFile;
        }
    }
}
