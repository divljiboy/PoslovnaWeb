using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class KlijentConfiguration:ModelBaseConfiguration<Klijent>
    {
        public KlijentConfiguration()
        {
            HasRequired(x => x.NaseljenoMesto).WithMany().HasForeignKey(x => x.NaseljenoMestoId);
            Property(x => x.Naziv).IsRequired().HasMaxLength(120);
            Property(x => x.Adresa).IsRequired().HasMaxLength(30);

        }

    }
}
