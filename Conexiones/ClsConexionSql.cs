using System;
using System.Data.SqlClient;
//using System.Windows.Forms;

namespace Conexiones
{
    public class ClsConexionSql
    {
        SqlConnection conexionSql;
        public SqlCommand ComandoSql;
        public static bool SibaseDatosSql = false;
        public static string CadenaConexion = string.Empty;
        public ClsConexionSql(string consulta)
        {
            try
            {
                this.conexionSql = new SqlConnection(ClsConexionSql.CadenaConexion);
                this.ComandoSql = new SqlCommand(consulta, this.conexionSql);
            }
            catch (Exception)
            {
              //  MessageBox.Show(ex.Message.ToString(), "ERROR CONEXION");
            }

        }
        public bool SiConexionSql
        {
            get
            {
                try
                {

                    if (this.conexionSql.State == System.Data.ConnectionState.Closed)
                    {
                        this.conexionSql.Open();
                    }
                }
                catch (Exception)
                {
                    return false;
                }

                return true;
            }
        }
        public bool CerrarConexionSql
        {
            get
            {

                if (this.conexionSql.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        this.conexionSql.Close();
                        this.conexionSql.Dispose();
                    }
                    catch (Exception)
                    {
                        //ex.Message.ToString();
                        return false;
                    }
                }
                return true;
            }

        }
    }
}
