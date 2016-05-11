using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class DnevnoStanjeRacuna : IModelBase
    {
        
        public int Id { get; set; }
        public DateTime DatumPrometa { get; set; }
        public decimal PrethodnoStanje { get; set; }
        public decimal PrometUKorist { get; set; }
        public decimal PrometNaTeret { get; set; }
        public decimal NovoStanje { get; set; }
        public RacunPravnihLica racunPravnihLica { get; set; }
        private ICollection<AnalitikaIzvoda> _izvodi;
        internal ICollection<AnalitikaIzvoda> Izvodi
        {
            get
            {
                return _izvodi;
            }

            set
            {
                _izvodi = value;
            }
        }

        

    }
}
