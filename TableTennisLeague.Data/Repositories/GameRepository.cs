using System;
using System.Collections.Generic;
using System.Text;
using TableTennisLeague.Data.Interfaces;
using TableTennisLeague.Data.Model;

namespace TableTennisLeague.Data.Repositories
{
    public class GameRepository
    {
        private readonly ISQLiteConnectionFactory _connectionFactory;
        public GameRepository(ISQLiteConnectionFactory connectionFactory)
        {
            this._connectionFactory = connectionFactory;
        }

        public Game GetGame(int gameId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetGamesForPlayer(int playerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetGamesForLeague(int leagueId)
        {
            throw new NotImplementedException();
        }

        public void CreateGame(Game game)
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(Game game)
        {
            throw new NotImplementedException();
        }

        public void DeleteGame(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}
