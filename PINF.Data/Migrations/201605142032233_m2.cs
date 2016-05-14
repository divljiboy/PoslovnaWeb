namespace PINF.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.User", newName: "Korisnik");
            RenameTable(name: "dbo.UserRole", newName: "KorisnikUloga");
            CreateTable(
                "dbo.AnalitikaIzvoda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Duznik = c.String(nullable: false, maxLength: 256),
                        SvrhaPlacanja = c.String(nullable: false, maxLength: 256),
                        Poverilac = c.String(nullable: false, maxLength: 256),
                        DatumPrijema = c.DateTime(nullable: false),
                        DatumValute = c.DateTime(nullable: false),
                        RacunDuznika = c.String(maxLength: 18),
                        ModelZaduzenja = c.Int(),
                        PozivNaBrojZaduzenja = c.String(maxLength: 20),
                        RacunPoverioca = c.String(maxLength: 18),
                        ModelOdobrenja = c.Int(),
                        PozivNaBrojOdobrenja = c.String(maxLength: 20),
                        Hitno = c.Boolean(nullable: false),
                        Iznos = c.Decimal(nullable: false, precision: 15, scale: 2),
                        TipGreske = c.Int(nullable: false),
                        Status = c.Int(),
                        DnevnoStanjeRacunaId = c.Int(nullable: false),
                        NaseljenoMestoId = c.Int(),
                        VrstaPlacanjaId = c.Int(),
                        ValutaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DnevnoStanjeRacuna", t => t.DnevnoStanjeRacunaId)
                .ForeignKey("dbo.NaseljenoMesto", t => t.NaseljenoMestoId)
                .ForeignKey("dbo.Valuta", t => t.ValutaId)
                .ForeignKey("dbo.VrstePlacanja", t => t.VrstaPlacanjaId)
                .Index(t => t.DnevnoStanjeRacunaId)
                .Index(t => t.NaseljenoMestoId)
                .Index(t => t.VrstaPlacanjaId)
                .Index(t => t.ValutaId);
            
            CreateTable(
                "dbo.DnevnoStanjeRacuna",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumPrometa = c.DateTime(nullable: false),
                        PrethodnoStanje = c.Decimal(nullable: false, precision: 15, scale: 2),
                        PrometUKorist = c.Decimal(nullable: false, precision: 15, scale: 2),
                        PrometNaTeret = c.Decimal(nullable: false, precision: 15, scale: 2),
                        NovoStanje = c.Decimal(nullable: false, precision: 15, scale: 2),
                        RacunKlijentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RacunKlijent", t => t.RacunKlijentId)
                .Index(t => t.RacunKlijentId);
            
            CreateTable(
                "dbo.RacunKlijent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrojRacuna = c.String(nullable: false, maxLength: 18),
                        DatumOtvaranja = c.DateTime(nullable: false),
                        Vazeci = c.Boolean(nullable: false),
                        KlijentId = c.Int(nullable: false),
                        BankaId = c.Int(nullable: false),
                        ValutaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banka", t => t.BankaId)
                .ForeignKey("dbo.Klijent", t => t.KlijentId)
                .ForeignKey("dbo.Valuta", t => t.ValutaId)
                .Index(t => t.KlijentId)
                .Index(t => t.BankaId)
                .Index(t => t.ValutaId);
            
            CreateTable(
                "dbo.Banka",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sifra = c.String(nullable: false, maxLength: 3),
                        PIB = c.Int(nullable: false),
                        Naziv = c.String(nullable: false, maxLength: 120),
                        Adresa = c.String(nullable: false, maxLength: 120),
                        Email = c.String(maxLength: 128),
                        WebSite = c.String(maxLength: 128),
                        Telefon = c.String(maxLength: 20),
                        Faks = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KursnaLista",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        datum = c.DateTime(nullable: false),
                        BrojKursneListe = c.Int(nullable: false),
                        PrimenjujeSeOd = c.DateTime(nullable: false),
                        BankaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banka", t => t.BankaId)
                .Index(t => t.BankaId);
            
            CreateTable(
                "dbo.KursUValuti",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kupovni = c.Decimal(nullable: false, precision: 9, scale: 4),
                        Srednji = c.Decimal(nullable: false, precision: 9, scale: 4),
                        Prodajni = c.Decimal(nullable: false, precision: 9, scale: 4),
                        KursnaListaId = c.Int(nullable: false),
                        OsnovnaValutaId = c.Int(nullable: false),
                        PremaValutiId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KursnaLista", t => t.KursnaListaId)
                .ForeignKey("dbo.Valuta", t => t.OsnovnaValutaId)
                .ForeignKey("dbo.Valuta", t => t.PremaValutiId)
                .Index(t => t.KursnaListaId)
                .Index(t => t.OsnovnaValutaId)
                .Index(t => t.PremaValutiId);
            
            CreateTable(
                "dbo.Valuta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ZvanicnaSifra = c.String(nullable: false, maxLength: 3),
                        Naziv = c.String(nullable: false, maxLength: 30),
                        Domicilna = c.Boolean(nullable: false),
                        DrzavaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drzava", t => t.DrzavaId)
                .Index(t => t.DrzavaId);
            
            CreateTable(
                "dbo.Drzava",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NaseljenoMesto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 60),
                        PttOznaka = c.String(nullable: false, maxLength: 12),
                        DrzavaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drzava", t => t.DrzavaId)
                .Index(t => t.DrzavaId);
            
            CreateTable(
                "dbo.Klijent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 120),
                        NaseljenoMestoId = c.Int(nullable: false),
                        Adresa = c.String(nullable: false, maxLength: 30),
                        Telefon = c.String(),
                        Email = c.String(),
                        Faks = c.String(),
                        OdgovornoLice = c.String(),
                        NazivDelatnosti = c.String(),
                        SifraDelatnosti = c.Int(),
                        PIB = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NaseljenoMesto", t => t.NaseljenoMestoId)
                .Index(t => t.NaseljenoMestoId);
            
            CreateTable(
                "dbo.Ukidanje",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumUkidanje = c.DateTime(nullable: false),
                        RacunZaPrenos = c.String(nullable: false, maxLength: 20),
                        RacuniId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RacunKlijent", t => t.RacuniId)
                .Index(t => t.RacuniId);
            
            CreateTable(
                "dbo.VrstePlacanja",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivVrstePlacanja = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AnalitikaIzvoda", "VrstaPlacanjaId", "dbo.VrstePlacanja");
            DropForeignKey("dbo.AnalitikaIzvoda", "ValutaId", "dbo.Valuta");
            DropForeignKey("dbo.AnalitikaIzvoda", "NaseljenoMestoId", "dbo.NaseljenoMesto");
            DropForeignKey("dbo.AnalitikaIzvoda", "DnevnoStanjeRacunaId", "dbo.DnevnoStanjeRacuna");
            DropForeignKey("dbo.DnevnoStanjeRacuna", "RacunKlijentId", "dbo.RacunKlijent");
            DropForeignKey("dbo.RacunKlijent", "ValutaId", "dbo.Valuta");
            DropForeignKey("dbo.Ukidanje", "RacuniId", "dbo.RacunKlijent");
            DropForeignKey("dbo.RacunKlijent", "KlijentId", "dbo.Klijent");
            DropForeignKey("dbo.Klijent", "NaseljenoMestoId", "dbo.NaseljenoMesto");
            DropForeignKey("dbo.RacunKlijent", "BankaId", "dbo.Banka");
            DropForeignKey("dbo.KursUValuti", "PremaValutiId", "dbo.Valuta");
            DropForeignKey("dbo.KursUValuti", "OsnovnaValutaId", "dbo.Valuta");
            DropForeignKey("dbo.Valuta", "DrzavaId", "dbo.Drzava");
            DropForeignKey("dbo.NaseljenoMesto", "DrzavaId", "dbo.Drzava");
            DropForeignKey("dbo.KursUValuti", "KursnaListaId", "dbo.KursnaLista");
            DropForeignKey("dbo.KursnaLista", "BankaId", "dbo.Banka");
            DropIndex("dbo.Ukidanje", new[] { "RacuniId" });
            DropIndex("dbo.Klijent", new[] { "NaseljenoMestoId" });
            DropIndex("dbo.NaseljenoMesto", new[] { "DrzavaId" });
            DropIndex("dbo.Valuta", new[] { "DrzavaId" });
            DropIndex("dbo.KursUValuti", new[] { "PremaValutiId" });
            DropIndex("dbo.KursUValuti", new[] { "OsnovnaValutaId" });
            DropIndex("dbo.KursUValuti", new[] { "KursnaListaId" });
            DropIndex("dbo.KursnaLista", new[] { "BankaId" });
            DropIndex("dbo.RacunKlijent", new[] { "ValutaId" });
            DropIndex("dbo.RacunKlijent", new[] { "BankaId" });
            DropIndex("dbo.RacunKlijent", new[] { "KlijentId" });
            DropIndex("dbo.DnevnoStanjeRacuna", new[] { "RacunKlijentId" });
            DropIndex("dbo.AnalitikaIzvoda", new[] { "ValutaId" });
            DropIndex("dbo.AnalitikaIzvoda", new[] { "VrstaPlacanjaId" });
            DropIndex("dbo.AnalitikaIzvoda", new[] { "NaseljenoMestoId" });
            DropIndex("dbo.AnalitikaIzvoda", new[] { "DnevnoStanjeRacunaId" });
            DropTable("dbo.VrstePlacanja");
            DropTable("dbo.Ukidanje");
            DropTable("dbo.Klijent");
            DropTable("dbo.NaseljenoMesto");
            DropTable("dbo.Drzava");
            DropTable("dbo.Valuta");
            DropTable("dbo.KursUValuti");
            DropTable("dbo.KursnaLista");
            DropTable("dbo.Banka");
            DropTable("dbo.RacunKlijent");
            DropTable("dbo.DnevnoStanjeRacuna");
            DropTable("dbo.AnalitikaIzvoda");
            RenameTable(name: "dbo.KorisnikUloga", newName: "UserRole");
            RenameTable(name: "dbo.Korisnik", newName: "User");
        }
    }
}
