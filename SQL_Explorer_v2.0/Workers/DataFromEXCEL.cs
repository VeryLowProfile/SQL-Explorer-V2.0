using System.Windows.Forms;
using System;
using System.Data;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace SQL_Explorer_v2._0.Workers
{
    class DataFromEXCEL
    {
        public List<string> GetSheetsList(string filePath)
        {
            List<string> sheetsList = new List<string>();

            try
            {

                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Open(filePath);

                foreach (Excel.Worksheet worksheet in excel.Worksheets)
                {
                    sheetsList.Add(worksheet.Name);
                }

                workbook.Close();
                excel.Quit();

                GC.WaitForPendingFinalizers();
                GC.Collect();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            return sheetsList;
        }

        public DataTable FillDataTable(string filePath, int SheetNumber, DataTable dataTable)
        {

            try
            {

                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Open(filePath);
                Excel.Worksheet worksheet = workbook.Sheets[SheetNumber];
                Excel.Range range = worksheet.UsedRange;

                int rowRange = range.Rows.Count;
                int colRange = range.Columns.Count;

                DataRow row;
                dataTable.Rows.Clear();

                for (int i = 2; i <= range.Rows.Count; i++)
                {
                    row = dataTable.NewRow();
                    for (int j = 1; j <= range.Columns.Count; j++)
                    {
                        if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                        {
                            row[j - 1] = range.Cells[i, j].Value2;

                        }
                        else
                        {
                            row[j - 1] = " ";
                        }
                    }
                    dataTable.Rows.Add(row);
                }

                workbook.Close();
                excel.Quit();

                GC.WaitForPendingFinalizers();
                GC.Collect();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            return dataTable;
        }

        public void Export(DataTable dataTable, string filePath)
        {
            try
            {

                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Export";
                excel.Visible = true;
                excel.DisplayAlerts = false;

                for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= dataTable.Columns.Count - 1; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
                    }
                }

                workbook.SaveAs(filePath);

                workbook.Close();
                excel.Quit();

                GC.WaitForPendingFinalizers();
                GC.Collect();

            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
