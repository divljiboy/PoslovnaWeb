using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class VrstePlacanja : IModelBase
    {

        public int Id { get; set; }
        public string NazivVrstePlacanja { get; set; }
        private ICollection<AnalitikaIzvoda> _izvodi;

        internal ICollection<AnalitikaIzvoda> Izvodi
        {
            get
            {
                return _izvodi;
            }

            set
            {
                _izvodi = value;
            }
        }

        

    }
}
