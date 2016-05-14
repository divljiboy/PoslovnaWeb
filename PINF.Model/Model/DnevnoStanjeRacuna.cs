using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    public class DnevnoStanjeRacuna : IModelBase
    {

        public int Id { get; set; }
        public DateTime DatumPrometa { get; set; }
        public decimal PrethodnoStanje { get; set; }
        public decimal PrometUKorist { get; set; }
        public decimal PrometNaTeret { get; set; }
        public decimal NovoStanje { get; set; }

        public int RacunKlijentId {get;set;}
        public RacunKlijent RacuniKlijenata { get; set; }

        public ICollection<AnalitikaIzvoda> Izvodi { get; set; }

        

    }
}
