using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class DnevnoStanjeRacunaConfiguration : ModelBaseConfiguration<DnevnoStanjeRacuna>
    {

        public DnevnoStanjeRacunaConfiguration()
        {
            Property(x => x.DatumPrometa).IsRequired();
            Property( x => x.NovoStanje).IsRequired().HasPrecision(15,2);
            Property( x => x.PrethodnoStanje).IsRequired().HasPrecision(15, 2);
            Property( x => x.PrometNaTeret).IsRequired().HasPrecision(15, 2);
            Property( x => x.PrometUKorist).IsRequired().HasPrecision(15, 2);


            HasRequired(x => x.RacuniKlijenata).WithMany(x => x.DnevnoStanjeracuna).HasForeignKey(x => x.RacunKlijentId);
        }
    }
}
