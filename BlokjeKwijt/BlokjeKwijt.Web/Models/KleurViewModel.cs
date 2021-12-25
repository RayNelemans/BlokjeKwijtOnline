using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Web.Models
{
    public class KleurViewModel
    {
        public int Id { get; set; }
        public string KleurNaam { get; set; }
        [Display(Name = "Kleur")]
        public string KleurCode { get; set; }
    }
}
