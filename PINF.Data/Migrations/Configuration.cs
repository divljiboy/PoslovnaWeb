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
                new KorisnikUloga {Id = 1, Role = KorisnikUloga.ADMIN, About = "Administrator" }
            );

            context.DbUser.AddOrUpdate(
                x => x.Email,
                new Korisnik { FirstName = "DivljiBoj93" , LastName = "lalala" , Password = "1" , Email = "1@gmail.com", RoleId = 1 }
            );
        }
    }
}
