using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokjeKwijt.Data
{
    public class BlokjeKwijtContext : DbContext
    {
        public DbSet<Blokje> Blokjes { get; set; }
        public DbSet<Kleur> Kleuren { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Aanvraag> Aanvragen { get; set; }
        public DbSet<BlokjesVerzoek> BlokjesVerzoeken { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.EnableSensitiveDataLogging();
                optionsBuilder.UseSqlServer("Server=.;Database=BlokjeKwijt; Trusted_connection= true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blokje>().HasData(
                new Blokje { Id = 1, BlokNummer = 10, Lengte = 10, Breedte = 5, Hoogte = Hoogte.Normaal_Blokje, Nopjes = 50, KleurId = 1, ImageName = "Rood.jpg"},
                new Blokje { Id = 2, BlokNummer = 5, Lengte = 4, Breedte = 2, Hoogte = Hoogte.Plat, Nopjes = 20, KleurId = 2, ImageName = "Geel.jpg" },
                new Blokje { Id = 3, BlokNummer = 8, Lengte = 4, Breedte = 5, Hoogte = Hoogte.Groot_Blokje, Nopjes = 32, KleurId = 3, ImageName = "Blauw.jpg" }
                );

            modelBuilder.Entity<Kleur>().HasData(
                new Kleur { Id = 1, KleurNaam = "Rood", KleurCode = "#ff0000" },
                new Kleur { Id = 2, KleurNaam = "Geel", KleurCode = "##FFFF00" },
                new Kleur { Id = 3, KleurNaam = "Blauw", KleurCode = "#0000FF" }
                );

            modelBuilder.Entity<Gebruiker>().HasData(
                new Gebruiker { Id = 1, Email = "ray@home.nl", Naam = "Ray", TelefoonNummer = "0612345678" },
                new Gebruiker { Id = 2, Email = "gijs@home.nl", Naam = "Gijs", TelefoonNummer = "0615935712" },
                new Gebruiker { Id = 3, Email = "nick@home.nl", Naam = "Nick", TelefoonNummer = "0687654321" }
                );

            modelBuilder.Entity<Aanvraag>().HasData(
                new Aanvraag { Id = 1, Email = "ray@home.nl" , Naam = "Ray", TelefoonNummer = "0612345678", Bericht = "Ik zou graag een groen blokje aan willen vragen met 6 nopjes" },
                new Aanvraag { Id = 2, Email = "gijs@home.nl", Naam = "Gijs", TelefoonNummer = "0615935712", Bericht = "Ik zou graag een roze blokje willen aanvragen met 12 nopjes"},
                new Aanvraag { Id = 3, Email = "nick@home.nl", Naam = "Nick", TelefoonNummer = "0687654321", Bericht = "Ik zou graag een oranje blokje aan willen vragen met 14 nopjes" }
                );

            modelBuilder.Entity<BlokjesVerzoek>().HasData(
                new BlokjesVerzoek { Id = 1, BlokjeId = 1, BlokjeOverKwijt = OverKwijt.Kwijt, BlokjesVerzoekStatus = Status.Niet_Afgerond},
                new BlokjesVerzoek { Id = 2, BlokjeId = 1, BlokjeOverKwijt = OverKwijt.Over, BlokjesVerzoekStatus = Status.Niet_Afgerond }
                );

        }
    }
}
