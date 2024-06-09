using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProdutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double CapacidadeProducao { get; set; }
        public TipoEnergiaProdutor TipoEnergia { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataInicioOperacao { get; set; }
        public bool Ativo { get; set; }
    }
    public enum TipoEnergiaProdutor
    {
        Solar,
        Eolica,
        Hidreletrica,
        Termica 
    }

}
