using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class AnalitikaIzvodaConfiguration:ModelBaseConfiguration<AnalitikaIzvoda>
    {
        public AnalitikaIzvodaConfiguration()
        {
            Property(x => x.SvrhaPlacanja).IsRequired().HasMaxLength(256);
            Property(x => x.DatumPrijema).IsRequired();
            Property(x => x.DatumValute).IsRequired();
            Property(x => x.Hitno).IsRequired();
            Property(x => x.Iznos).IsRequired().HasPrecision(15, 2);
            Property(x => x.TipGreske).IsRequired();
            Property(x => x.Status).IsOptional();
            Property(x => x.RacunPoverioca).IsOptional().HasMaxLength(18);
            Property(x => x.PozivNaBrojOdobrenja).IsOptional().HasMaxLength(20);
            Property(x => x.PozivNaBrojZaduzenja).IsOptional().HasMaxLength(20);
            Property(x => x.ModelOdobrenja).IsOptional();
            Property(x => x.ModelZaduzenja).IsOptional();
            Property(x => x.Duznik).IsRequired().HasMaxLength(256);
            Property(x => x.Poverilac).IsRequired().HasMaxLength(256);
            Property(x => x.RacunDuznika).IsOptional().HasMaxLength(18);



            HasOptional(x => x.VrstaPlacanja).WithMany(x => x.Izvodi).HasForeignKey(x => x.VrstaPlacanjaId);
            HasRequired(x => x.DnevnoStanjeRacuna).WithMany(x => x.Izvodi).HasForeignKey(x => x.DnevnoStanjeRacunaId);
            HasOptional(x => x.NaseljenoMesto).WithMany(x => x.Izvodi).HasForeignKey(x => x.NaseljenoMestoId);
            HasOptional(x => x.Valuta).WithMany(x => x.Izvodi).HasForeignKey(x => x.ValutaId);


        }
    }
}
