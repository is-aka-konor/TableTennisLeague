using System.Data.SqlClient;
using System.Data.SQLite;
using TableTennisLeague.Data.Interfaces;

namespace TableTennisLeague.Data.Connection
{
    public class SQLiteConnectionFactory : ISQLiteConnectionFactory
    {
        private readonly string _defaultConnectionString;
        public SQLiteConnectionFactory(string defaultConnection)
        {
            this._defaultConnectionString = defaultConnection;
        }
        public SQLiteConnection CreateConnection()
        {
            return CreateConnection(this._defaultConnectionString);
        }

        public SQLiteConnection CreateConnection(string connectionString)
        {
            return new SQLiteConnection($"{connectionString};");
        }
    }
}