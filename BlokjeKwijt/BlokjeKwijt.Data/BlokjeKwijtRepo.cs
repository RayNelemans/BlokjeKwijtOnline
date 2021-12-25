using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokjeKwijt.Data
{
    public class BlokjeKwijtRepo
    {
        #region Blokje
        public List<Blokje> GetBlokjes()
        {
            List<Blokje> blokjes = new();
            using (var ctx = new BlokjeKwijtContext())
            {
                blokjes = ctx.Blokjes.Include(b => b.KleurBlokje).ToList();
            }
            return blokjes;
        }

        public Blokje GetSingleBlokje(int id)
        {
            Blokje blokje = new();
            using (var ctx = new BlokjeKwijtContext())
            {
                blokje = ctx.Blokjes.Include(b => b.KleurBlokje).FirstOrDefault(b => b.Id == id);
            }
            return blokje;
        }

        public List<Blokje> FilteredBlokjes(string bloknr, string lengte, string breedte, string nopjes)
        {
            using (var ctx = new BlokjeKwijtContext())
            {
                List<Blokje> blokjes = ctx.Blokjes.Include(b => b.KleurBlokje).ToList();

                if (!string.IsNullOrEmpty(bloknr))
                {
                    blokjes = blokjes.Where(s => s.BlokNummer.ToString().Equals(bloknr)).ToList();
                }
                if (!string.IsNullOrEmpty(lengte))
                {
                    blokjes = blokjes.Where(l => l.Lengte.ToString().Equals(lengte)).ToList();
                }
                if (!string.IsNullOrEmpty(breedte))
                {
                    blokjes = blokjes.Where(h => h.Breedte.ToString().Equals(breedte)).ToList();
                }
                if (!string.IsNullOrEmpty(nopjes))
                {
                    blokjes = blokjes.Where(l => l.Nopjes.ToString().Equals(nopjes)).ToList();
                } 
                return blokjes;
            }
        }

        public List<Kleur> FillColorList()
        {
            List<Kleur> kleuren = new();
            using (var ctx = new BlokjeKwijtContext())
            {
                kleuren = ctx.Kleuren.ToList();
            }
            return kleuren;
        }

        public void AddBlokje(Blokje blokje)
        {
            using var ctx = new BlokjeKwijtContext();
            ctx.Entry(blokje).State = EntityState.Added;
            ctx.SaveChanges();
        }
        #endregion Blokje

        #region Kleur
        public List<Kleur> GetKleuren()
        {
            List<Kleur> kleuren = new();
            using (var ctx = new BlokjeKwijtContext())
            {
                kleuren = ctx.Kleuren.ToList();
            }
            return kleuren;
        }

        public Kleur GetSingleKleur(int id)
        {
            Kleur kleuren = new();
            using (var ctx = new BlokjeKwijtContext())
            {
                kleuren = ctx.Kleuren.FirstOrDefault(b => b.Id == id);
            }
            return kleuren;
        }

        public void AddKleur(Kleur kleur)
        {
            using var ctx = new BlokjeKwijtContext();
            ctx.Entry(kleur).State = EntityState.Added;
            ctx.SaveChanges();
        }

        public void EditKleur(Kleur kleur)
        {
            using var ctx = new BlokjeKwijtContext();
            ctx.Update(kleur);
            ctx.SaveChanges();
        }

        public void DeleteKleur(Kleur kleur)
        {
            using var ctx = new BlokjeKwijtContext();
            ctx.Entry(kleur).State = EntityState.Deleted;
            ctx.SaveChanges();
        }
        #endregion Kleur

        #region Aanvraag
        public List<Aanvraag> GetAanvragen()
        {
            List<Aanvraag> aanvragen = new();
            using (var ctx = new BlokjeKwijtContext())
            {
                aanvragen = ctx.Aanvragen.ToList();
            }
            return aanvragen;
        }

        public Aanvraag GetSingleAanvraag(int id)
        {
            Aanvraag aanvragen = new();
            using (var ctx = new BlokjeKwijtContext())
            {
                aanvragen = ctx.Aanvragen.FirstOrDefault(b => b.Id == id);
            }
            return aanvragen;
        }

        public void AddAanvraag(Aanvraag aanvraag)
        {
            using var ctx = new BlokjeKwijtContext();
            ctx.Entry(aanvraag).State = EntityState.Added;
            ctx.SaveChanges();
        }

        public void DeleteAanvraag(Aanvraag aanvraag)
        {
            using var ctx = new BlokjeKwijtContext();
            ctx.Entry(aanvraag).State = EntityState.Deleted;
            ctx.SaveChanges();
        }
        #endregion Aanvraag
    }
}
