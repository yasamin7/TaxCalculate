using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace congestion.calculator.Helper
{
    public static class TollFreeDateCalculator
    {
        public static bool IsFree(this DateTime dateTime)
        {

            if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday) return true;

            List<DateTime> datetimes = new List<DateTime>();

            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();

                string query = "SELECT MyDateTime FROM TollFreeDate";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        datetimes.Add(date);
                    }
                }

                connection.Close();
            }

            foreach(var item in datetimes)
            {
                if(DateTime.Compare(item,dateTime) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
