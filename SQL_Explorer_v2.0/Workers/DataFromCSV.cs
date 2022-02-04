using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace SQL_Explorer_v2._0.Workers
{
    class DataFromCSV
    {
        public DataTable FillDataTable(string filePath, char separator)
        {
            DataTable dataTable = new DataTable();
            string[] rows = File.ReadAllLines(filePath);
            string[] rowValues = null;
            DataRow row = dataTable.NewRow();

            if (rows.Length > 0)
            {
                foreach (string columnName in rows[0].Split(separator))
                {
                    dataTable.Columns.Add(columnName);
                }

            }

            for (int i = 1; i < rows.Length; i++)
            {
                rowValues = rows[i].Split(separator);
                row = dataTable.NewRow();
                row.ItemArray = rowValues;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        public void Export(DataTable dataTable, string filePath, char separator)
        {
            StreamWriter sw = new StreamWriter(filePath, false);
 
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                sw.Write(dataTable.Columns[i]);
                if (i < dataTable.Columns.Count - 1)
                {
                    sw.Write(separator);
                }
            }
            sw.Write(sw.NewLine);

            foreach (DataRow dr in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dataTable.Columns.Count - 1)
                    {
                        sw.Write(separator);
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

    }
}
