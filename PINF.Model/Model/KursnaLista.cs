using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    public class KursnaLista : IModelBase
    {
        public int Id { get; set; }
        //bhgjhgjhgjhghj
        public DateTime datum { get; set; }
        public int BrojKursneListe { get; set; }
        public DateTime PrimenjujeSeOd { get; set; }

        public int BankaId { get; set; }
        public Banka Banka { get; set; }


        private ICollection<KursUValuti> _kurseviUValuti;
        public ICollection<KursUValuti> KurseviUValuti
        {
            get
            {
                return _kurseviUValuti == null ? new HashSet<KursUValuti>() : _kurseviUValuti;
            }

            set
            {
                _kurseviUValuti = value;
            }
        }

    }
}
