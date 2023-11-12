using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comun
{
   public static class DataGrid_2
    {
        public static DataSet GetDataSet( DataGridView dgv)
        {
            var ds = new DataSet();
            var dt = new DataTable();

            foreach (var column in dgv.Columns.Cast<DataGridViewColumn>())
            {
                if (column.Visible)
                {
                    if (column.Index == 0)
                    {
                        column.Name = "NombreEmpresa";
                    }
                    if (column.Name!= "EliminarCorreoE")
                    {
                        dt.Columns.Add();
                    }
                  
                }
            }

            var cellValues = new object[dgv.Columns.Count];
            foreach (var row in dgv.Rows.Cast<DataGridViewRow>())
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            ds.Tables.Add(dt);
        return ds;
        }
    }
}
