using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    public class Ukidanje : IModelBase
    {
        public int Id { get; set; }
        public DateTime DatumUkidanje { get; set; }
        public string RacunZaPrenos { get; set; }

        public int RacuniId { get; set; }
        public RacunKlijent Racuni { get; set; }


    }

}
