using BlokjeKwijt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Web.Models
{
    public class AanvraagViewModel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
        public string TelefoonNummer { get; set; }
        public string Bericht { get; set; }
    }
}
