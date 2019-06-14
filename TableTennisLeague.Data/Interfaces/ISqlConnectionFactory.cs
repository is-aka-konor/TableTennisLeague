using System.Data.SQLite;

namespace TableTennisLeague.Data.Interfaces
{
    public interface ISQLiteConnectionFactory
    {
        SQLiteConnection CreateConnection();
        SQLiteConnection CreateConnection(string connectionString);
    }
}