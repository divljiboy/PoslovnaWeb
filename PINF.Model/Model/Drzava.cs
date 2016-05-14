using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    public class Drzava : IModelBase
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public ICollection<Valuta> Valute { get; set; }

        private ICollection<NaseljenoMesto> _naseljenaMesta;

        public ICollection<NaseljenoMesto> NaseljenaMesta
        {
            get
            {
                return _naseljenaMesta == null ? new HashSet<NaseljenoMesto>() : _naseljenaMesta;
            }

            set
            {
                _naseljenaMesta = value;
            }
        }

      

    }
}
