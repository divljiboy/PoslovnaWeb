using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class Valuta : IModelBase
    {

        public int Id {get; set;}
        public string ZvanicnaSifra { get; set; }
        public string Naziv { get; set; }
        public bool Domicilna { get; set; }
        private ICollection<KursUValuti> _osnovneValute;
        private ICollection<KursUValuti> _premaValuti;

        private ICollection<RacunPravnihLica> _racuniPravnihLica;
        private ICollection<Drzava> _drzave;

        internal ICollection<KursUValuti> OsnovneValute
        {
            get
            {
                return _osnovneValute;
            }

            set
            {
                _osnovneValute = value;
            }
        }

        

        internal ICollection<KursUValuti> PremaValuti
        {
            get
            {
                return _premaValuti;
            }

            set
            {
                _premaValuti = value;
            }
        }

        internal ICollection<RacunPravnihLica> RacuniPravnihLica
        {
            get
            {
                return _racuniPravnihLica;
            }

            set
            {
                _racuniPravnihLica = value;
            }
        }

        internal ICollection<Drzava> Drzave
        {
            get
            {
                return _drzave;
            }

            set
            {
                _drzave = value;
            }
        }

      
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

        private ICollection<AnalitikaIzvoda> _izvodi;

    }
}
