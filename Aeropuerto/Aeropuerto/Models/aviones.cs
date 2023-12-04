using System.ComponentModel.DataAnnotations;

namespace Aeropuerto.Models
{
    public class aviones
    {
        public int AvionId { get; set; }
        public string modelo { get; set; }
        public int peso { get; set; }
        public int capacidad { get; set; }
        public string hangar_id { get; set; }

    }
}
