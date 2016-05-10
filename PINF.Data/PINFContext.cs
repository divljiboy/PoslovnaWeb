using PINF.Data.Configurations;
using PINF.Model.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PINF.Data
{
    public class PINFContext : DbContext
    {

        #region DbSets

        public IDbSet<UserRole> DbUserRole { get; set; }
        public IDbSet<User> DbUser { get; set; }

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
