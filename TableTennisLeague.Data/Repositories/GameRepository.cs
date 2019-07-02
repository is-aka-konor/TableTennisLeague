using System;
using System.Collections.Generic;
using Dapper;
using TableTennisLeague.Data.Interfaces;
using TableTennisLeague.Data.Models;
using TableTennisLeague.Data.SqlCommands;

namespace TableTennisLeague.Data.Repositories
{
    public class GameRepository: IGameRepository
    {
        // TODO Create error handling -> prevent exception throwing
        private readonly ISQLiteConnectionFactory _connectionFactory;
        public GameRepository(ISQLiteConnectionFactory connectionFactory)
        {
            this._connectionFactory = connectionFactory;
        }

        public GameViewModel GetGame(int gameId)
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.GetGameById;
                var game = connection.QuerySingle<GameViewModel>(command, new { GameId = gameId });
                connection.Close();
                return game;
            }
        }

        public IEnumerable<GameViewModel> GetAllGames()
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.GetAllGames;
                var games = connection.Query<GameViewModel>(command);
                connection.Close();
                return games;
            }
        }
        public IEnumerable<GameViewModel> GetGamesForPlayer(int playerId)
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.GetAllGamesByPlayerId;
                var games = connection.Query<GameViewModel>(command, new { PlayerId = playerId });
                connection.Close();
                return games;
            }
        }

        public IEnumerable<GameViewModel> GetGamesForLeague(int leagueId)
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.GetAllGamesByLeagueId;
                var games = connection.Query<GameViewModel>(command, new { LeagueId = leagueId });
                connection.Close();
                return games;
            }
        }

        public IEnumerable<GameViewModel> GetGamesForSeason(int seasonId)
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = GameCommands.GetAllGamesBySeasonId;
                var games = connection.Query<GameViewModel>(command, new { SeasonId = seasonId });
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
                var games = connection.Execute(command, new { GameId = gameId });
                connection.Close();
            }
        }
    }
}
