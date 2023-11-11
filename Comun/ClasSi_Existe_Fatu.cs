using Conexiones;
using System.Data.SqlClient;
namespace ComunApp
{
    public  class ClasSi_Existe_Fatu
    {
        public static bool Buscar_Fatu_Sql(string valor)
        {
            bool ok = true;
            string Consulta = "SELECT [EnlaceFactura] FROM [DtNuevaFactura] where DtNuevaFactura.EnlaceFactura=' "+valor+" '";
            ClsConexionSql NuevaConexion = new ClsConexionSql(Consulta);
            if (NuevaConexion.SiConexionSql)
            {
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@EnlaceFactura",valor.ToString());
                SqlDataReader r = NuevaConexion.ComandoSql.ExecuteReader();
                if (r.HasRows)
                {
                    ok = true;
                }
                else
                {
                    ok = false;
                }
            }
            return ok;
        }
    }
}
