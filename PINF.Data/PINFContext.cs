using PINF.Data.Configurations;
using PINF.Model.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PINF.Data
{
    public class PINFContext : DbContext
    {

        #region DbSets

        public IDbSet<KorisnikUloga> DbUserRole { get; set; }
        public IDbSet<Korisnik> DbUser { get; set; }
        public IDbSet<Drzava> DbDrzava { get; set; }
        public IDbSet<NaseljenoMesto> DbNaseljenoMesto { get; set; }
        public IDbSet<VrstePlacanja> DbVrstePlacanja { get; set; }
        public IDbSet<DnevnoStanjeRacuna> DbDnevnoStanjeRacuna { get; set; }
        public IDbSet<AnalitikaIzvoda> DbAnalitikaIzvoda { get; set; }
        public IDbSet<Banka> DbBanka { get; set; }
        public IDbSet<Klijent> DbKlijent { get; set; }
        public IDbSet<KursnaLista> DbKursnaLista { get; set; }
        public IDbSet<KursUValuti> DbKursUValuti { get; set; }
        public IDbSet<RacunKlijent> DbRacunKlijent { get; set; }
        public IDbSet<Ukidanje> DbUkidanje { get; set; }
        public IDbSet<Valuta> DbValuta { get; set; }

        #endregion DbSets

        public PINFContext() :
            base("name=PINF.Web.Properties.Settings.PINFConnection")
        {
            Database.SetInitializer<PINFContext>(new CreateDatabaseIfNotExists<PINFContext>());
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Conventions

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            #endregion Conventions

            #region Configurations

            modelBuilder.Configurations.Add(new UserRoleConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

            #endregion Configurations
        }
    }
}
