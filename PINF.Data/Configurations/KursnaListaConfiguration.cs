using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class KursnaListaConfiguration:ModelBaseConfiguration<KursnaLista>
    {
        public KursnaListaConfiguration()
        {

            Property(x => x.datum).IsRequired();
            Property(x => x.BrojKursneListe).IsRequired();
            Property(x => x.PrimenjujeSeOd).IsRequired();


            HasRequired(x => x.Banka).WithMany(x => x.KursneListe).HasForeignKey(x => x.BankaId);

        }
    }
}
