using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class Klijent:User
    {
      
        private ICollection<RacunPravnihLica> racuni;

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
    }
}
