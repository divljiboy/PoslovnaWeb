using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class VrstePlacanjaConfiguration:ModelBaseConfiguration<Model.Model.VrstePlacanja>
    {

        public VrstePlacanjaConfiguration()
        {
            Property(x => x.NazivVrstePlacanja).IsRequired().HasMaxLength(120);

        }
    }
}
