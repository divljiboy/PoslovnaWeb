using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class BankaConfiguration:ModelBaseConfiguration<Banka>
    {

        public BankaConfiguration()
        {
            Property(x => x.Sifra).IsRequired().HasMaxLength(3);
            Property(x => x.PIB).IsRequired();
            Property(x => x.Naziv).IsRequired().HasMaxLength(120);
            Property(x => x.Adresa).IsRequired().HasMaxLength(120);
            

            //bool banka?

            Property(x => x.Email).IsOptional().HasMaxLength(128);
            Property(x => x.WebSite).IsOptional().HasMaxLength(128);
            Property(x => x.Telefon).IsOptional().HasMaxLength(20);
            Property(x => x.Faks).IsOptional().HasMaxLength(20);
        }
            
    }
}
