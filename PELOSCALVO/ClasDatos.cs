using System;
using System.IO;

namespace PELOSCALVO
{
    public static class ClasDatos
    {
        public static int ValorBuscado;
        // public static int IdNumeroTarifa = 5;
        // public static string DirectorioActual = Directory.GetCurrentDirectory();
        public static string RutaFactura = "";
        public static string RutaDatosPrincipal = "Datos";
        public static string RutaBaseDatosDb = Directory.GetCurrentDirectory() + "\\" + RutaDatosPrincipal + "\\" + "Datos App Peloscalvo.accdb";
        public static string NombreFactura = "Factura";
        public static string Datos1Datos2 = "";
        public static Boolean OkFacturar = false;
        public static string QUEform = "";
        public static FormFacturar FormFACTURAR33;
        public static int count = 0;

    }

    public class CrearBaseDatos
    {
        public string ServidoresCrear { get; set; }
        public string BaseDatosCrear { get; set; }
    }
}
