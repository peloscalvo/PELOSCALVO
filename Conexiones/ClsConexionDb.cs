using System;
using System.Data.OleDb;
using System.Data.SqlClient;
//using System.Windows.Forms;

namespace Conexiones
{
    public class ClsConexionDb
    {

        OleDbConnection conexionDb;
        public OleDbCommand ComandoDb;
        public static bool SibaseDatosSql = false;
        public static string CadenaConexion = "";
        public ClsConexionDb(string consulta)
        {
            try
            {
                this.conexionDb = new OleDbConnection(ClsConexionDb.CadenaConexion);
                ComandoDb = new OleDbCommand(consulta, conexionDb);
            }
            catch (Exception)
            {

               /// MessageBox.Show(ex.Message.ToString(), "(((ERROR))) Base Datos Archivo");
            }
        }
        public bool SiConexionDb
        {
            get
            {
              
                if (this.conexionDb.State == System.Data.ConnectionState.Closed)
                {
                    try
                    {

                        this.conexionDb.Open();

                    }
     
                    catch (Exception )
                    {
                     // MessageBox.Show(ex.Message.ToString());
                        return false;
                    }

                }
                return true;
            } 
        }
        public bool CerrarConexionDB
        {
            get
            {

                if (this.conexionDb.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        this.conexionDb.Close();
                    }
                    catch (Exception)
                    {
                        this.conexionDb.Close();
                        //ex.Message.ToString();
                        return false;
                    }
                }
                return true;
            }
        }
    }


  


    }




