using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class NaseljenoMestoConfiguration : ModelBaseConfiguration<NaseljenoMesto>
    {

        public NaseljenoMestoConfiguration()
        {
            Property(x => x.Naziv).IsRequired().HasMaxLength(60);
            Property(x => x.PttOznaka).IsRequired().HasMaxLength(12);

            HasRequired(x => x.Drzava).WithMany(x => x.NaseljenaMesta).HasForeignKey(x => x.DrzavaId);

            

        }
        
    }
}
