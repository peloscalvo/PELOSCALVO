using System.Collections.Generic;

namespace Comun
{
    public static class ClasCorreos
    {
        public class CorreosEmpresasDb
        {
            public int Id { get; set; }
            public string NombreCorreo { get; set; }
            public string Empresa { get; set; }

        }
        public class CorreosClientesDb
        {
            public int Id { get; set; }
            public string NombreCorreo { get; set; }
            public string Empresa { get; set; }

        }
        public static class ListaCorreosEmpresa
        {
            public static List<CorreosEmpresasDb> lista = new List<CorreosEmpresasDb>();
        }
        public static class ListaCorreosCliente
        {
            public static List<CorreosClientesDb> lista = new List<CorreosClientesDb>();
        }
    }
}
