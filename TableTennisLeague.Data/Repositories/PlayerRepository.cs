using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TableTennisLeague.Data.Interfaces;
using TableTennisLeague.Data.Model;

namespace TableTennisLeague.Data.Repositories
{
    public class PlayerRepository: IPlayerRepository
    {
        private SqlConnection _connection;
        private bool _disposed = false;
        public PlayerRepository(SqlConnection connection)
        {
            this._connection = connection;
        }

        public Player GetPlayer()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetPlayers(int leagueId)
        {
            throw new NotImplementedException();
        }

        public void InsertPlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public void UpdatePlayer(Player player)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Player> IPlayerRepository.GetPlayers()
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    this._connection.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
