using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ConsumidorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double ConsumoEnergia { get; set; }
        public TipoEnergiaConsumidor PreferenciaEnergia { get; set; } 
        public double DespesaMensalEnergia { get; set; }
        public bool ContratoAtivo { get; set; }
        [JsonIgnore]
        public ICollection<ProdutorModel> Produtores { get; set; }
    }
    public enum TipoEnergiaConsumidor
    {
        Renovavel,
        NaoRenovavel 
    }

}
