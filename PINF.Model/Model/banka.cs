using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    public class Banka : IModelBase
    {
        public int Id { get; set; }
        public string Sifra { get; set; }
        public int PIB { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
        //public bool Banka { get; set; }

        public ICollection<RacunKlijent> Racuni { get; set; }
        public ICollection<KursnaLista> KursneListe { get; set; }

        

    }
}
