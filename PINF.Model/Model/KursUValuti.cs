using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class KursUValuti : IModelBase
    {
        public int Id { get; set; }
        public decimal Kupovni { get; set; }
        public decimal Srednji { get; set; }
        public decimal Prodajni { get; set; }
        public KursnaLista kursnaLista { get; set; }
        public Valuta osnovnaValuta { get; set; }
        public Valuta premaValuti { get; set; }
    }
}
