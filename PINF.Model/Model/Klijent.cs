using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    public class Klijent : IModelBase
    {
        public int Id { get; set; }
        //naziv = ime+prezime
        public string Naziv { get; set; }

        public int NaseljenoMestoId{get; set;}
        public NaseljenoMesto NaseljenoMesto { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Faks { get; set; }
        public string OdgovornoLice { get; set; }
        public string NazivDelatnosti { get; set; }
        public int? SifraDelatnosti { get; set; }
        public int? PIB { get; set; }

        public ICollection<RacunKlijent> RacuniKlijenata { get; set; }

    }
}
