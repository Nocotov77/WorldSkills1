using System;
using Microsoft.Data.Sqlite;


namespace ConsoleApp_ADO.net // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sqlExpression = "SELECT * FROM Users;";
            using (var connection = new SqliteConnection("Data Source=..\\..\\..\\WorldSkills1"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            object id = reader["_id"];
                            object name = reader["Name"];
                            object age = reader["Age"];

                            Console.WriteLine($"{id} \t {name} \t {age}");
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}
