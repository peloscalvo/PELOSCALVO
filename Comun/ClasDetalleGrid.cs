using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public static class ClasDetalleGrid
    {
        public class Detalle
        {
            public string Referencia { get; set; }
            public string Cantidad { get; set; }
            public string Descripcci { get; set; }
            public string Precio { get; set; }
            public string Descuento { get; set; }
            public string Iva { get; set; }
            public string Importe { get; set; }
    

        }
        public class Detalle2
        {
            public string Referencia { get; set; }
            public double Cantidad { get; set; }
            public string Descripcci { get; set; }
            public double Precio { get; set; }
            public double Descuento { get; set; }
           // public double Iva { get; set; }
            public double Importe { get; set; }
       

        }
        public static class Listadetalle1
        {
            public static List<Detalle> lista = new List<Detalle>();
        }
        public static class Listadetalle2
        {
            public static List<Detalle2> lista = new List<Detalle2>();
        }
    }
}
