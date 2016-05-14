using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class DrzavaConfiguration : ModelBaseConfiguration<Drzava>
    {
        public DrzavaConfiguration()
        {
            Property(x => x.Naziv).IsRequired();
            
        }
    }
}
