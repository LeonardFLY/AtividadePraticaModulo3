using System.ComponentModel.DataAnnotations;

namespace AtividadeModulo3.Models
{
    public class Destinos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String? Saida { get; set; }
        [Required]
        public String? CidadeSaida { get; set; }
        [Required]
        public String? EstadoSaida { get; set; }
        [Required]
        public String? AeroportoSaida { get; set; }
        public String? Chegada { get; set; }
        public String? CidadeChegada { get; set; }
        [Required]
        public String? EstadoChegada { get; set; }
        [Required]
        public String? AeroportoCHegada { get; set; }
        [Required]
        public Double Valor { get; set; }
    }
}
