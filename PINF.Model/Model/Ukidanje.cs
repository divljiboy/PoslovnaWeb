using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class Ukidanje : IModelBase
    {
        public int Id { get; set; }
        public DateTime datumUkidanje { get; set; }
        public string RacunZaPrenos { get; set; }
        public RacunPravnihLica Racuni { get; set; }


    }

}
