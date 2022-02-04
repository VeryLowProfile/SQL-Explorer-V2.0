using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace SQL_Explorer_v2._0.Workers
{

    class DataFromSQL
    {
        public DataTable FillDataTable(string connString, string tableName)
        {

            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connString;

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM  " + tableName, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            return dataTable;
        }

        public List<string> GetTablesInDB(string connString)
        {

            List<string> tablesList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connString;

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tablesList.Add(reader["TABLE_NAME"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            return tablesList;
        }

        public void SendTableMod(string connString, string tableName, DataTable modDataTable)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connString;

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM  " + tableName, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataTable);
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetDeleteCommand();
                dataAdapter.Update(modDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
