using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class RacunKlijentConfiguration:ModelBaseConfiguration<RacunKlijent>
    {
        public RacunKlijentConfiguration()
        {
            Property(x => x.BrojRacuna).IsRequired().HasMaxLength(18);
            Property(x => x.DatumOtvaranja).IsRequired();
            Property(x => x.Vazeci).IsRequired();


            HasRequired(x => x.Valuta).WithMany(x => x.RacuniKlijenata).HasForeignKey(x => x.ValutaId);
            HasRequired(x => x.Banka).WithMany(x => x.RacuniKlijenata).HasForeignKey(x => x.BankaId);
            HasRequired(x => x.Klijent).WithMany(x => x.RacuniKlijenata).HasForeignKey(x => x.KlijentId);





        }

    }
}
