using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;

namespace PELOSCALVO
{
    public class ClsOjetos
    {
        public static string[] instanciasInstaladas()
        {
            try
            {

                Microsoft.Win32.RegistryKey Reguistro;
                Reguistro = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server", false);
                string[] instancia;
                if ((string[])Reguistro.GetValue("InstalledInstances") != null)
                {
                    instancia = ((string[])Reguistro.GetSubKeyNames());
                    return null;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
                //throw;
            }
        }

        public class SqlServerInstance
        {
            public string ServerInstance { get; set; }
            public string Version { get; set; }
        }

        public static List<SqlServerInstance> LocateSqlInstances()
        {
            List<SqlServerInstance> results = new List<SqlServerInstance>();

            using (DataTable sqlSources = SqlDataSourceEnumerator.Instance.GetDataSources())
            {
                foreach (DataRow source in sqlSources.Rows)
                {
                    string servername;
                    string instancename = source["InstanceName"].ToString();

                    if (!string.IsNullOrEmpty(instancename))
                    {
                        servername = source["ServerName"].ToString() + '\\' + instancename;
                    }
                    else
                    {
                        servername = source["ServerName"].ToString();
                    }

                    results.Add(new SqlServerInstance() { ServerInstance = servername, Version = source["Version"].ToString() });
                }
            }

            return results;
        }

    }
}
