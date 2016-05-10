namespace PINF.Data.Migrations
{
    using Model.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PINF.Data.PINFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PINF.Data.PINFContext context)
        {
            context.DbUserRole.AddOrUpdate(
                x => x.Role,
                new UserRole { Role = UserRole.ADMIN, About = "Administrator" }
            );
        }
    }
}
