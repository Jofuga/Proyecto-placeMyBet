using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatchAPI.Models
{
    public class Market
    {
        //Iniciamos y declaramos variables de mercado
        public Market(int idMercado, int idPartido, double cuotaO, double cuotaU, double dineroO, double dineroU, double golesMerc)
        {
            this.idMercado = idMercado;
            this.idPartido = idPartido;
            this.cuotaO = cuotaO;
            this.cuotaU = cuotaU;
            this.dineroO = dineroO;
            this.dineroU = dineroU;
            this.golesMerc = golesMerc;
        }

        public int idMercado { get; set; }
        public int idPartido { get; set; }
        public double golesMerc { get; set; }
        public double cuotaO { get; set; }
        public double cuotaU { get; set; }
        public double dineroO { get; set; }
        public double dineroU { get; set; }
    }
}