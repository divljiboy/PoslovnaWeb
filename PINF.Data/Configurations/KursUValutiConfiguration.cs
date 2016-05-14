using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class KursUValutiConfiguration:ModelBaseConfiguration<KursUValuti>
    {

        public KursUValutiConfiguration()
        {
            Property(x => x.Prodajni).IsRequired().HasPrecision(9,4);
            Property(x => x.Kupovni).IsRequired().HasPrecision(9, 4);
            Property(x => x.Srednji).IsRequired().HasPrecision(9, 4);

            HasRequired(x => x.OsnovnaValuta).WithMany(x => x.OsnovneValute).HasForeignKey(x => x.OsnovnaValutaId);
            HasRequired(x => x.PremaValuti).WithMany(x => x.PremaValuti).HasForeignKey(x => x.PremaValutiId);
            HasRequired(x => x.KursnaLista).WithMany(x => x.KurseviUValuti).HasForeignKey(x => x.KursnaListaId);


        }
    }
}
