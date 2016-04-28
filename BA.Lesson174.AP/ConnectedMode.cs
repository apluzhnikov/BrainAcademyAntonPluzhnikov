using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson174.AP
{
    static class ConnectedMode
    {
        public static void ExampleRun() {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AirlineManagerDB"].ConnectionString;
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                var queryStringBuilder = new StringBuilder();
                //ConsoleKeyInfo key = new ConsoleKeyInfo();

                do
                {
                    /*do
                    {
                        key = Console.ReadKey();
                        queryStringBuilder.Append(key.KeyChar);
                    } while (key.Key != ConsoleKey.Enter || key.Key != ConsoleKey.Escape);

                    if (key.Key == ConsoleKey.Escape)
                        break;*/

                    var line = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                        break;
                    queryStringBuilder.AppendLine(line);




                    using (var sqlCommand = new SqlCommand(queryStringBuilder.ToString(), sqlConnection))
                    {
                        if (queryStringBuilder.ToString().StartsWith("select", StringComparison.InvariantCultureIgnoreCase))
                        {
                            queryStringBuilder.Clear();
                            using (var sqlDataReader = sqlCommand.ExecuteReader())
                            {
                                while (sqlDataReader.Read())
                                {
                                    for (int i = 0; i < sqlDataReader.FieldCount - 1; i++)
                                    {
                                        if (i == sqlDataReader.FieldCount)
                                            queryStringBuilder.AppendLine($"{sqlDataReader[i]}; ");
                                        else
                                            queryStringBuilder.Append($"{sqlDataReader[i]} ;");
                                    }
                                }
                                Console.WriteLine(queryStringBuilder.ToString());
                            }
                        } else
                        {
                            var amountRowsAdjusted = sqlCommand.ExecuteNonQuery();
                            Console.WriteLine($"Amount of rows adjusted {amountRowsAdjusted}");

                        }
                    }
                    queryStringBuilder.Clear();
                } while (true);
            }
        }
    }
}
