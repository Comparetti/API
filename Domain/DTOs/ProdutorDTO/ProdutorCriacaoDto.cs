using Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.ProdutorDTO
{
    public class ProdutorCriacaoDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome é obrigatório.")]
        [StringLength(100)]
        public string Sobrenome { get; set; }

        [Required]
        [Range(0, Double.MaxValue, ErrorMessage = "A capacidade de produção deve ser um número positivo.")]
        public double CapacidadeProducao { get; set; }

        [Required]
        public TipoEnergiaProdutor TipoEnergia { get; set; }

        [Required(ErrorMessage = "A localização é obrigatória.")]
        [StringLength(200)]
        public string Localizacao { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataInicioOperacao { get; set; }
    }
}
