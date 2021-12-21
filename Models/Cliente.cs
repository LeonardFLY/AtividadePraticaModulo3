using System.ComponentModel.DataAnnotations;

namespace AtividadeModulo3.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String? Nome { get; set; }
        [Required]
        [StringLength(11)]
        public String? Cpf { get; set; }
        [Required]
        public String? Nascimento { get; set; }
        [Required]
        public String? Endereço { get; set; }
        [Required]
        public String? Numero { get; set; }
        [Required]
        public String? Bairro { get; set; }
        [Required]
        [StringLength(8)]
        public String? Cep { get; set; }
        [Required]
        public String? Uf { get; set; }
        [Required]
        [MinLength(11)]
        public String? Celular { get; set; }
        [Required]
        public String? email { get; set; }
    }
}
