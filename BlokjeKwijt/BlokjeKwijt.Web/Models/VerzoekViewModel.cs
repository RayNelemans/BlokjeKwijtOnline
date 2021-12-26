using BlokjeKwijt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Web.Models
{
    public class VerzoekViewModel
    {
        public int Id { get; set; }
        public int BlokjeId { get; set; }
        public string Naam { get; set; }
        public string TelefoonNummer { get; set; }
        public string Email { get; set; }
        public List<BlokjeViewModel> BlokjesList { get; set; }
        public OverKwijt BlokjeOverKwijt { get; set; }
        public Status BlokjesVerzoekStatus { get; set; }
    }
}
