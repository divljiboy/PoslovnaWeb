using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    public class KursUValuti : IModelBase
    {
        public int Id { get; set; }
        public decimal Kupovni { get; set; }
        public decimal Srednji { get; set; }
        public decimal Prodajni { get; set; }

        public int KursnaListaId { get; set; }
        public KursnaLista KursnaLista { get; set; }

        public int OsnovnaValutaId { get; set; }
        public Valuta OsnovnaValuta { get; set; }

        public int PremaValutiId { get; set; }
        public Valuta PremaValuti { get; set; }
    }
}
