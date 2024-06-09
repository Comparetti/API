using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.ProdutorVinculoDTO
{
    public class ProdutorVinculoDTO
    {
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }

}
