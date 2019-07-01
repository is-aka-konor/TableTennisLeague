using System;
using System.Collections.Generic;
using Dapper;
using TableTennisLeague.Data.Interfaces;
using TableTennisLeague.Data.Model;
using TableTennisLeague.Data.SqlCommands;

namespace TableTennisLeague.Data.Repositories
{
    public class GameRepository: IGameRepository
    {
        private readonly ISQLiteConnectionFactory _connectionFactory;
        public GameRepository(ISQLiteConnectionFactory connectionFactory)
        {
            this._connectionFactory = connectionFactory;
        }

        public Game GetGame(int gameId)
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.GetGameById;
                var game = connection.QueryFirst<Game>(command, gameId);
                connection.Close();
                return game;
            }
        }

        public IEnumerable<Game> GetAllGames()
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.GetAllGames;
                var games = connection.Query<Game>(command);
                connection.Close();
                return games;
            }
        }
        public IEnumerable<Game> GetGamesForPlayer(int playerId)
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.GetAllGamesByPlayerId;
                var games = connection.Query<Game>(command, playerId);
                connection.Close();
                return games;
            }
        }

        public IEnumerable<Game> GetGamesForLeague(int leagueId)
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.GetAllGamesByLeagueId;
                var games = connection.Query<Game>(command, leagueId);
                connection.Close();
                return games;
            }
        }

        public IEnumerable<Game> GetGamesForSeason(int seasonId)
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.GetAllGamesBySeasonId;
                var games = connection.Query<Game>(command, seasonId);
                connection.Close();
                return games;
            }
        }

        public Game CreateGame(Game game)
        {
            throw new NotImplementedException();
        }

        public Game UpdateGame(Game game)
        {
            throw new NotImplementedException();
        }

        public void DeleteGame(int gameId)
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.DeleteGame;
                var games = connection.Execute(command, gameId);
                connection.Close();
            }
        }
    }
}
