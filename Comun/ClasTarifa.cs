using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public static class ClasTarifa
    {
        public class Tarifa
        {
            public int IdTarifa { get; set; }
            public string TarifaTipo { get; set; }
            public string EnlaceTarifa { get; set; }

        }
        public static class ListaTarifa
        {
            public static List<Tarifa> lista = new List<Tarifa>();
        }
    }

}
