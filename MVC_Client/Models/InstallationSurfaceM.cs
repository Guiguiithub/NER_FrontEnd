namespace MVC_Client.Models
{
    public class InstallationSurfaceM
    {
        public int length { get; set; }
        public int width { get; set; }
        public int surface { get; set; }

        public InstallationSurfaceM() { }
        
        public InstallationSurfaceM(int length, int width, int surface)
        {
            this.length = length;
            this.width = width;
            this.surface = surface;
        }
    }
}
