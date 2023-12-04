using System.ComponentModel.DataAnnotations;

namespace Aeropuerto.Models
{
    public class pilotos
    {
        public int PilotoId { get; set; }
        public string restricciones { get; set; }
        public decimal salario { get; set; }
        public string turno { get; set; }
 
        

    }
}
