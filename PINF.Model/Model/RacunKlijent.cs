

using System;
using System.Collections.Generic;

namespace PINF.Model.Model
{
    public class RacunKlijent : IModelBase
    {
        public int Id { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime DatumOtvaranja { get; set; }
        public bool Vazeci { get; set;}

        public int KlijentId { get; set; }
        public Klijent Klijent { get; set; }

        public int BankaId { get; set; }
        public Banka Banka { get; set; }

        private ICollection<Ukidanje> _ukidanja;
        public ICollection<Ukidanje> Ukidanja
        {
            get
            {
                return _ukidanja ?? (_ukidanja=new HashSet<Ukidanje>());
            }

            set
            {
                _ukidanja = value;
            }
        }


        private ICollection<DnevnoStanjeRacuna> _dnevnostanjeracuna;
        public ICollection<DnevnoStanjeRacuna> Dnevnostanjeracuna
        {
            get
            {
                return _dnevnostanjeracuna ?? (_dnevnostanjeracuna = new HashSet<DnevnoStanjeRacuna>());
            }

            set
            {
                _dnevnostanjeracuna = value;
            }
        }

        public int ValutaId { get; set; }
        public Valuta Valuta { get; set; }


    }
}
