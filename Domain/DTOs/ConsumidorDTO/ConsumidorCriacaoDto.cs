using Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.ConsumidorDTO
{
    public class ConsumidorCriacaoDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome é obrigatório.")]
        [StringLength(100)]
        public string Sobrenome { get; set; }

        [Required]
        [Range(0, Double.MaxValue, ErrorMessage = "O consumo de energia deve ser um número positivo.")]
        public double ConsumoEnergia { get; set; }

        [Required]
        public TipoEnergiaConsumidor PreferenciaEnergia { get; set; }

        [Required]
        [Range(0, Double.MaxValue, ErrorMessage = "A despesa mensal deve ser um número positivo.")]
        public double DespesaMensalEnergia { get; set; }

        [Required]
        public bool ContratoAtivo { get; set; }
    }
}
