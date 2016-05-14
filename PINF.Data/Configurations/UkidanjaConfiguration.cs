using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{

    public class UkidanjaConfiguration:ModelBaseConfiguration<Ukidanje>
    {
        public UkidanjaConfiguration()
        {
            Property(x => x.DatumUkidanje).IsRequired();
            Property(x => x.RacunZaPrenos).IsRequired().HasMaxLength(20);


            HasRequired(x => x.Racuni).WithMany(x => x.Ukidanja).HasForeignKey(x => x.RacuniId);

        }

    }

}
