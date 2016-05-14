using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    public class Valuta : IModelBase
    {

        public int Id {get; set;}
        public string ZvanicnaSifra { get; set; }
        public string Naziv { get; set; }
        public bool Domicilna { get; set; }

        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }


        private ICollection<KursUValuti> _osnovneValute;
        private ICollection<KursUValuti> _premaValuti;

        public ICollection<RacunKlijent> RacuniKlijenata { get; set; }
        private ICollection<AnalitikaIzvoda> _izvodi;

        public ICollection<KursUValuti> OsnovneValute
        {
            get
            {
                return _osnovneValute ?? (new HashSet<KursUValuti>());
            }

            set
            {
                _osnovneValute = value;
            }
        }



        public ICollection<KursUValuti> PremaValuti
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

       


        public ICollection<AnalitikaIzvoda> Izvodi
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
