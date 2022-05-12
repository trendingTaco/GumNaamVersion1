namespace Wakanda_Mini_API.Models
{
    public class Audio
    {
 
        public int ID { get; set; }
         
        public byte[] FileData { get; set; }
        public string LocalFileName { get; set; }
        public string MIMEType { get; set; }

    }
}
