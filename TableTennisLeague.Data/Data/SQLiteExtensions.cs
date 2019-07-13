using System;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace TableTennisLeague.Data.Data
{
public static class SQLiteExtensions
    {
        public static void ExecuteNonQuery(
            this SQLiteConnection connection,
            string commandText)
        {
            // Ensure we have a connection
            if (connection == null)
            {
                throw new NullReferenceException("Please provide a connection");
            }

            // Ensure that the connection state is Open
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            // Use Dapper to execute the given query
            connection.Execute(commandText);
        }
    }

}