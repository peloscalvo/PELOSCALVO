using System.Collections.Generic;

namespace Comun
{
    public static class ClasArticulos
    {
        public class ArticulosDb
        {
            public int Id { get; set; }
            public string Referencia { get; set; }
            public string Descripcci { get; set; }
            public double Coste { get; set; }
            public double Ganancia { get; set; }
            public double Pvp1 { get; set; }
            public double PvpIva { get; set; }
            public double Pvp2Desc { get; set; }
            public double Pvp2 { get; set; }
            public double CastyDesc { get; set; }
            public double Casty { get; set; }
            public double SuarezDesc { get; set; }
            public double Suarez { get; set; }
            public double BenitoDesc { get; set; }
            public double Benito { get; set; }
            public double ValenteDes { get; set; }
            public double Valente { get; set; }
            public double PlusDesc { get; set; }
            public double Plus { get; set; }
            public double Stock { get; set; }
            public string Familia { get; set; }
            public string Fecha { get; set; }
            public string UnidadPale { get; set; }
            public string MinimosSto { get; set; }
            public bool Baja { get; set; }
            public bool Fatu { get; set; }
            public int IdFILA { get; set; }
        }
        public static class ListaArticulos
        {
            public static List<ArticulosDb> lista = new List<ArticulosDb>();
        }

    }
}
