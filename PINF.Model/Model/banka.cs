using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class Banka : IModelBase
    {
        public int Id
        {
            get;

            set;
        }

        internal ICollection<RacunPravnihLica> Racuni
        {
            get
            {
                return racuni;
            }

            set
            {
                racuni = value;
            }
        }

        internal ICollection<KursnaLista> KursneListe
        {
            get
            {
                return _kursneListe;
            }

            set
            {
                _kursneListe = value;
            }
        }

        public string Sifra_Banke { get; set; }
        public string PIB { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
        public bool Banka1 { get; set; }
        private ICollection<RacunPravnihLica> racuni;
        private ICollection<KursnaLista> _kursneListe;



    }
}
