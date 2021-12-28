using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Web.Models
{
    public class MatchViewModel
    {
        public VerzoekViewModel Verzoek { get; set; }
        public List<VerzoekViewModel> VerzoekenList { get; set; }
    }
}
