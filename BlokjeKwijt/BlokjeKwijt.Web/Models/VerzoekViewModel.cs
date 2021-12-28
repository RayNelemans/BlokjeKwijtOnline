using BlokjeKwijt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Web.Models
{
    public class VerzoekViewModel
    {
        public int Id { get; set; }
        public int BlokjeId { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        [RegularExpression(@"(^\+[0-9]{2}|^\+[0-9]{2}\(0\)|^\(\+[0-9]{2}\)\(0\)|^00[0-9]{2}|^0)([0-9]{9}$|[0-9\-\s]{10}$)", ErrorMessage ="Telefoonnummer is onjuist")]
        public string TelefoonNummer { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email is onjuist")]
        public string Email { get; set; }
        public List<BlokjeViewModel> BlokjesList { get; set; }
        public OverKwijt BlokjeOverKwijt { get; set; }
        public Status BlokjesVerzoekStatus { get; set; }
    }
}
