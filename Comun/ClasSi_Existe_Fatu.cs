using Conexiones;
using System.Data.SqlClient;

namespace ComunApp
{
    public  class ClasSi_Existe_Fatu
    {
        public static bool Buscar_Fatu_Sql(string valor,string Tabla)
        {
            bool ok = true;
            string Consulta = "SELECT [EnlaceFactura] FROM [Dt"+Tabla+ "] where "+"Dt" + Tabla + ".EnlaceFactura=' " + valor+" '";
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
