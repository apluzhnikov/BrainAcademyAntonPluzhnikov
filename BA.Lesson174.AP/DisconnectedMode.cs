using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson174.AP
{
    class DisconnectedMode
    {
        public static void ExampleRun() {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AirlineManagerDB"].ConnectionString;
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var sqlTransaction = sqlConnection.BeginTransaction();
                using (var sqlCommand = new SqlCommand("Select * from Airport", sqlConnection, sqlTransaction))
                using (var sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                using (var dataSet = new DataSet("AirportSet"))
                {
                    
                    sqlDataAdapter.Fill(dataSet, "Airport");
                    var airportTable = dataSet.Tables["Airport"];
                    var dataRow = airportTable.NewRow();
                    ShowDataSet(airportTable);
                    dataSet.WriteXml(@"d:\dataset.xml");
                    dataSet.WriteXmlSchema(@"d:\dataset.xsd");
                    dataRow["Name"] = "VS Airport3";
                    dataRow["Address"] = "VS Address3";
                    airportTable.Rows.Add(dataRow);

                    try
                    {

                        var insertCommand = new SqlCommandBuilder(sqlDataAdapter).GetInsertCommand();
                        insertCommand.Transaction = sqlTransaction;
                        sqlDataAdapter.InsertCommand = insertCommand;
                        sqlDataAdapter.Update(airportTable);
                        sqlTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static void ShowDataSet(DataTable table) {
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn colomn in table.Columns)
                {
                    Console.Write(row[colomn] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
