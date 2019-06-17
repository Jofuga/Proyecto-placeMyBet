using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatchAPI.Models
{
    public class Match
    {
        //Iniciamos y declaramos variables de partidos
        public Match(int idPartido, string equipoLoc, string equipoVis, List<Market> markets)
        {
            this.idPartido = idPartido;
            this.equipoLoc = equipoLoc;
            this.equipoVis = equipoVis;
            this.markets = markets;
        }

        public int idPartido { get; set; }
        public string equipoLoc { get; set; }
        public string equipoVis { get; set; }
        public List<Market> markets { get; set; }
    }
}