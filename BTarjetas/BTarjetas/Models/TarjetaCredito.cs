using System.ComponentModel.DataAnnotations;

namespace BTarjetas.Models
{
    public class TarjetaCredito
    {
        public int IdTarjetaCredito { get; set; }
        [Required]
        [MaxLength(10)]
        public string Titular { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string NumeroTarjeta { get; set; }
        [Required]
        
        public string FechaExpiracion { get; set; }
        [Required]

        public string Cvv { get; set; }
    }
}
