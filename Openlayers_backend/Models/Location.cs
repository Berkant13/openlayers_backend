using System.ComponentModel.DataAnnotations;

namespace Openlayers_backend.Models
{
    public class Location
    {
        [Key]
        public int id { get; set; }
        public string wkt { get; set; }
        public string sehir { get; set; }
        public string ilce { get; set; }
    }
}
