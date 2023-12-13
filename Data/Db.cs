

using Microsoft.Data.Sqlite;

namespace congestion.calculator.Data
{
    public class Db
    {
        readonly string connectionString = "Data Source=database.db";

        public void Connect()
        {
            using SqliteConnection connection = new SqliteConnection(connectionString);
            connection.Open();

            string createTableCommand = "CREATE TABLE IF NOT EXISTS TollFreeDate (Id INTEGER PRIMARY KEY, MyDateTime DATETIME DEFAULT CURRENT_TIMESTAMP)";
            using (SqliteCommand command = new SqliteCommand(createTableCommand, connection))
            {
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
   
}
