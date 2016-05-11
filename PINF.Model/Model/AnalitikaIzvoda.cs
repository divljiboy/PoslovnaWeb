using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class AnalitikaIzvoda : IModelBase
    {

        public int Id { get; set; }
        public string Duznik { get; set; }
        public string SvrhaPlacanja { get; set; }
        public string Poverilac { get; set; }
        public DateTime DatumPrijema { get; set; }
        public DateTime DatumValute { get; set; }
        public string RacunDuznika { get; set; }
        public int ModelZaduzenja { get; set; }
        public string PozivNaBrojZaduzenja { get; set; }
        public string RacunPoverioca { get; set; }
        public int ModelOdobrenja { get; set; }
        public string PozivNaBrojOdobrenja { get; set; }
        public bool Hitno { get; set; }
        public decimal Iznos { get; set; }
        public int TipGreske { get; set; }
        public char Status { get; set; }
        public DnevnoStanjeRacuna dnevnoStanjeRacuna { get; set; }
        public NaseljenoMesto naseljenoMesto { get; set; }
        public VrstePlacanja vrstaPlacanja { get; set; }
        public Valuta valuta { get; set; }

    }
}
