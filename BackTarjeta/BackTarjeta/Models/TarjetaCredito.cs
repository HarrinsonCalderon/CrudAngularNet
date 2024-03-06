using System.ComponentModel.DataAnnotations;

namespace BackTarjeta.Models
{
    public class TarjetaCredito
    {
        public int IdTarjetaCredito { get; set; }
        [Required]
        public string Titular { get; set; }
        [Required]
        public string NumeroTarjeta { get; set; }
        [Required]
        public string FechaExpiracion { get; set; }
        [Required]
        public string  Cvv { get; set; }
    }
}
