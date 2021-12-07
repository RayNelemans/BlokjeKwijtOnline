using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokjeKwijt.Data
{
    public class BlokjesVerzoek
    {
        public int Id { get; set; }
        public int BlokjeId { get; set; }
        public OverKwijt BlokjeOverKwijt { get; set; }
        public Status BlokjesVerzoekStatus { get; set; }
    }

    public enum OverKwijt
    {
        Over,
        Kwijt
    }
    public enum Status
    {
        Afgerond,
        Niet_Afgerond
    }
}
