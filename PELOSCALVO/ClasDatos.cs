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
        public static string RutaConfiguracionXml = Directory.GetCurrentDirectory() + "\\" + RutaDatosPrincipal + "\\" + "Configuracion.Xml";
        public static string RutaMultidatos = Directory.GetCurrentDirectory() + "\\" + RutaDatosPrincipal + "\\" + "MultiDatos.Xml";
        public static string RutaMulti2 = Directory.GetCurrentDirectory() + "\\" + RutaDatosPrincipal + "\\" + "Multi2.Xml";
        public static string ArchivoInicioFacturas;
        public static string NombreFactura = "Factura";
        public static string Datos1Datos2 = "";
        public static Boolean OkFacturar = false;
        public static string Clientes = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\";
        public static string Articulos = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\";
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
