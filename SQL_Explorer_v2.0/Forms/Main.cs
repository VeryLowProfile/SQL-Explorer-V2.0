using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using SQL_Explorer_v2._0.Workers;
using System.Windows.Forms;

namespace SQL_Explorer_v2._0
{
    public partial class Main : Form
    {

        DataFromXML dataFromXML = new DataFromXML();
        DataFromSQL dataFromSQL = new DataFromSQL();
        DataFromEXCEL dataFromEXCEL = new DataFromEXCEL();
        DataFromCSV dataFromCSV = new DataFromCSV();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            comboBoxMode.Text = "Select Import Mode";
            comboBoxMode.Items.Add("CSV");
            comboBoxMode.Items.Add("EXCEL");
            comboBoxMode.Text = "CSV";
            labelSheetName.Visible = false;
            comboBoxSheetName.Visible = false;
        }

        private void buttonReadConfig_Click(object sender, EventArgs e)
        {
            if (File.Exists("Config.xml"))
            {
                dataFromXML.GetConfigFromXML("Config.xml");
                dataFromXML.BuildConnString();
                textBoxIP.Text = dataFromXML.serverIP;
                textBoxServerName.Text = dataFromXML.serverName;
                textBoxDbName.Text = dataFromXML.dbName;
                textBoxUserId.Text = dataFromXML.userID;
                textBoxUserPwd.Text = dataFromXML.userPWD;
                textBoxConnString.Text = dataFromXML.connectionString;
            }
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            comboBoxSelectTable.Items.Clear();
            foreach (var table in dataFromSQL.GetTablesInDB(textBoxConnString.Text))
            {
                comboBoxSelectTable.Items.Add(table);
            }
        }

        private void buttonLoadRefresh_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = dataFromSQL.FillDataTable(textBoxConnString.Text, comboBoxSelectTable.SelectedItem.ToString());
            dataGridView.DataSource = dataTable;
            dataGridView.Update();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to store on SQL table Modifications?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                dataFromSQL.SendTableMod(textBoxConnString.Text, comboBoxSelectTable.SelectedItem.ToString(), (DataTable)dataGridView.DataSource);
            }

        }

        private void buttonClearDataGrid_Click(object sender, EventArgs e)
        {
            while (dataGridView.Rows.Count > 1)
            {
                foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
                {
                    if (!dataGridViewRow.IsNewRow)
                    {
                        dataGridView.Rows.Remove(dataGridViewRow);
                    }
                }
            }
            dataGridView.Update();
        }

        private void buttonSelectExcelFile_Click(object sender, EventArgs e)
        {           
            { 
                if (comboBoxMode.SelectedItem.ToString() == "EXCEL")
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Excel Workbook|*.xls; *xlsx";
                    openFileDialog.Title = "Select An Excel file";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        textBoxSelectedFile.Clear();
                        comboBoxSheetName.Items.Clear();
                        textBoxSelectedFile.Text = openFileDialog.FileName;
                        labelSheetName.Visible = true;
                        comboBoxSheetName.Visible = true;
                        foreach (string sheet in dataFromEXCEL.GetSheetsList(textBoxSelectedFile.Text))
                        {
                            comboBoxSheetName.Items.Add(sheet);
                        }
                        comboBoxSheetName.Text = comboBoxSheetName.Items[0].ToString();
                    }
                }
                else if (comboBoxMode.SelectedItem.ToString() == "CSV")
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "CSV File|*.csv; *txt";
                    openFileDialog.Title = "Select a CSV file";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        textBoxSelectedFile.Clear();
                        comboBoxSheetName.Items.Clear();
                        textBoxSelectedFile.Text = openFileDialog.FileName;
                        labelSheetName.Visible = false;
                        comboBoxSheetName.Visible = false;
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No IMPORT/EXPORT mode selected", "OK", MessageBoxButtons.YesNo);
                }
            }
        }

        private void buttonImportTable_Click(object sender, EventArgs e)
        {
            if (comboBoxMode.SelectedItem.ToString() == "EXCEL")
            {
                dataGridView.DataSource = dataFromEXCEL.FillDataTable(textBoxSelectedFile.Text, comboBoxSheetName.SelectedIndex + 1, (DataTable)dataGridView.DataSource);
                dataGridView.Update();
            }
            else if (comboBoxMode.SelectedItem.ToString() == "CSV")
            {
                dataGridView.DataSource = dataFromCSV.FillDataTable(textBoxSelectedFile.Text, ';');
                dataGridView.Update();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (comboBoxMode.SelectedItem.ToString() == "EXCEL")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Workbook|*xlsx";
                saveFileDialog.Title = "Create a Excel file";
                saveFileDialog.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop\";
                saveFileDialog.FileName = @"C:\Users\" + Environment.UserName + @"\Desktop\" + "Table_Export.xlsx";

                if (saveFileDialog.FileName != "" && saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dataFromEXCEL.Export((DataTable)dataGridView.DataSource, saveFileDialog.FileName);
                }
            }
            else if (comboBoxMode.SelectedItem.ToString() == "CSV")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV File|*csv";
                saveFileDialog.Title = "Create a CSV file";
                saveFileDialog.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop\";
                saveFileDialog.FileName = @"C:\Users\" + Environment.UserName + @"\Desktop\" + "Table_Export.csv";

                if (saveFileDialog.FileName != "" && saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dataFromCSV.Export((DataTable)dataGridView.DataSource, saveFileDialog.FileName, ';');
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("No IMPORT/EXPORT mode selected", "OK", MessageBoxButtons.YesNo);
            }
        }

    }
}
