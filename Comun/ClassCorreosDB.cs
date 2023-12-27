using System.Data;

namespace Comun
{
    public class ClassCorreosDB
    {
        public static DataSet dsCorreos = new DataSet("Dscorreos");
        public static DataTable DtCorreos = new DataTable("DtCorreos");
        public static DataTable DtCorreosCliente = new DataTable("DtCorreosCliente");
       
        public  void FF()
        {
            DtCorreos.Columns.Add("Id", typeof(int));
            DtCorreos.Columns.Add("NombreEmpresa", typeof(string));
           DtCorreos.Columns.Add("CorreoEletronico", typeof(string));
            DtCorreos.Columns.Add("Usuario", typeof(string));
           DtCorreos.Columns.Add("Contraseña", typeof(string));
            DtCorreos.Columns.Add("smtp", typeof(string));
            DtCorreos.Columns.Add("Puerto", typeof(int));
            DtCorreos.Columns.Add("Timeof", typeof(int));
            dsCorreos.Tables.Add(DtCorreos);
          
            DtCorreosCliente.Columns.Add("Id", typeof(int));
           DtCorreosCliente.Columns.Add("RazonSocial", typeof(string));
           DtCorreosCliente.Columns.Add("EmpresaNombre", typeof(string));
           DtCorreosCliente.Columns.Add("Direcion", typeof(string));
           DtCorreosCliente.Columns.Add("CorreoEletronico_cli", typeof(string));
            dsCorreos.Tables.Add(DtCorreosCliente);
        }
        
    }


}
