using Conexiones;
using System.Data.SqlClient;

namespace ComunApp
{
    public  class ClasSi_Existe_Fatu
    {
        public static bool Buscar_Fatu_Sql(string valor,string Tabla)
        {
            bool ok = true;
            string Consulta = "SELECT [EnlaceFactura] FROM [Dt"+Tabla+ "] where "+"Dt" + Tabla + ".EnlaceFactura=@EnlaceFactura";
            ClsConexionSql NuevaConexion = new ClsConexionSql(Consulta);
            if (NuevaConexion.SiConexionSql)
            {
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@EnlaceFactura",valor.ToString());
                SqlDataReader r = NuevaConexion.ComandoSql.ExecuteReader();
                if (r.HasRows)
                {
                    if (r.Read())
                    {
                        ok = true;
                    }
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
