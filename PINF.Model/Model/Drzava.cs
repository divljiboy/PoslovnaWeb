using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class Drzava : IModelBase
    {
        public int Id { get; set; }
        public string Naziv;
        public Valuta valuta { get; set; }
        private ICollection<NaseljenoMesto> _naseljenaMesta;

        internal ICollection<NaseljenoMesto> NaseljenaMesta
        {
            get
            {
                return _naseljenaMesta;
            }

            set
            {
                _naseljenaMesta = value;
            }
        }

      

    }
}
