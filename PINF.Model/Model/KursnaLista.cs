using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class KursnaLista : IModelBase
    {
        public int Id { get; set; }
        public DateTime datum { get; set; }
        public int BrojKursneListe { get; set; }
        public DateTime PrimenjujeSeOd { get; set; }
        public Banka banka { get; set; }
        private ICollection<KursUValuti> _kurseviUValuti;

        internal ICollection<KursUValuti> KurseviUValuti
        {
            get
            {
                return _kurseviUValuti;
            }

            set
            {
                _kurseviUValuti = value;
            }
        }

    }
}
