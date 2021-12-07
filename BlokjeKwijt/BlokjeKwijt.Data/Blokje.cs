using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokjeKwijt.Data
{
    public class Blokje
    {
        public int Id { get; set; }
        public int BlokNummer { get; set; }
        public int Lengte { get; set; }
        public int Breedte { get; set; }
        public Hoogte Hoogte { get; set; }
        public int Nopjes { get; set; }
        public Kleur KleurBlokje { get; set; }
        public int KleurId { get; set; }
        public string ImageName { get; set; }
    }

    public enum Hoogte
    {
        [Description("Groot Blokje")]
        Groot_Blokje,
        [Description("Mega Blokje")]
        Normaal_Blokje,
        [Description("Mega Blokje")]
        Plat,Blokje
    }
}
