using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class ValutaConfiguration:ModelBaseConfiguration<Valuta>
    {

        public ValutaConfiguration()
        {
            Property(x => x.Naziv).IsRequired().HasMaxLength(30);
            Property(x => x.ZvanicnaSifra).IsRequired().HasMaxLength(3);
            Property(x => x.Domicilna).IsRequired();


            HasRequired(x => x.Drzava).WithMany(x => x.Valute).HasForeignKey(x => x.DrzavaId);

        }


    }
}
