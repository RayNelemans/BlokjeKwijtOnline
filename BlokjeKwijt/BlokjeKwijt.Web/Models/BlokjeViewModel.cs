using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Web.Models
{
    public class BlokjeViewModel
    {
        public int Id { get; set; }
        public int BlokNummer { get; set; }
        public int Lengte { get; set; }
        public int Breedte { get; set; }
        public Hoogte Hoogte { get; set; }
        public int Nopjes { get; set; }
        public int KleurId { get; set; }
        public string ImageName { get; set; }
        [Required]
        public IFormFile ImageFile { get; set; }
        public List<KleurViewModel> KleurenLijst { get; set; }
    }

    public enum Hoogte
    {
        [Description("Groot Blokje")]
        Groot_Blokje,
        [Description("Mega Blokje")]
        Normaal_Blokje,
        [Description("Mega Blokje")]
        Plat_Blokje
    }
}
