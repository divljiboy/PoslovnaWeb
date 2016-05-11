using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class RacunPravnihLica:IModelBase
    {
        public int Id { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime DatumOtvaranja { get; set; }
        public bool Vazeci { get; set;}
        public User klijent { get; set; }
        public Banka banka { get; set; }

        public virtual ICollection<Ukidanje> Ukidanja
        {
            get
            {
                return _ukidanja??(_ukidanja=new HashSet<Ukidanje>());
            }

            set
            {
                _ukidanja = value;
            }
        }

        private ICollection<Ukidanje> _ukidanja;
        private ICollection<DnevnoStanjeRacuna> _dnevnostanjeracuna;


        public Valuta valuta { get; set; }

        internal ICollection<DnevnoStanjeRacuna> Dnevnostanjeracuna
        {
            get
            {
                return _dnevnostanjeracuna;
            }

            set
            {
                _dnevnostanjeracuna = value;
            }
        }
    }
}
