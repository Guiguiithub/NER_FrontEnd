namespace MVC_Client.Models
{
    public class OrientationM
    {
        public int azimutOrientation { get; set; }
        public int tiltOrientation { get; set; }

        public OrientationM() { }

        public OrientationM(int azimutOrientation, int tiltOrientation)
        {
            this.azimutOrientation = azimutOrientation;
            this.tiltOrientation = tiltOrientation;
        }
    }
}
