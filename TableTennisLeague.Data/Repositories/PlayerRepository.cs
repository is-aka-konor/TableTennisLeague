using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using TableTennisLeague.Data.Interfaces;
using TableTennisLeague.Data.Models;
using TableTennisLeague.Data.SqlCommands;

namespace TableTennisLeague.Data.Repositories
{
    public class PlayerRepository: IPlayerRepository
    {
        private readonly ISQLiteConnectionFactory _connectionFactory;
        public PlayerRepository(ISQLiteConnectionFactory connectionFactory)
        {
            this._connectionFactory = connectionFactory;
        }

        public Player GetPlayer(int id)
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = PlayerCommands.GetAllPlayers;
                var player = connection.QueryFirst<Player>(command);
                connection.Close();
                return player;
            }
        }
        public IEnumerable<Player> GetPlayers()
        {
            using(var connection = this._connectionFactory.CreateConnection())
            {
                connection.Open();
                var command = PlayerCommands.GetAllPlayers;
                var players = connection.Query<Player>(command);
                connection.Close();
                return players;
            }
        }
        public IEnumerable<Player> GetPlayers(int leagueId)
        {
            throw new NotImplementedException();
        }

        public void InsertPlayer(Player player)
        {
            using (var connection = this._connectionFactory.CreateConnection())
            {
                var command = PlayerCommands.CreatePlayer;
                // INSERT INTO [ttl.Players] ([Name], [CurrentRank], [Won], [WonOverTime], [Lost], [LostOverTime])
                // VALUES (@PlayerName, 1500, 0, 0, 0, 0);
                // @"INSERT Customer([CustomerFirstName],[CustomerLastName],[IsActive]) values (@CustomerFirstName, @CustomerLastName, @IsActive)",new { CustomerFirstName = ourCustomer.CustomerFirstName, CustomerLastName = ourCustomer.CustomerLastName, IsActive = true});

                var rowsAffected = connection.Execute(command, new
                {
                    Name = player.Name,
                    CurrentRank = 1500,
                    Won = 0,
                    WonOverTime = 0,
                    Lost = 0,
                    LostOverTime = 0
                });
            }
        }

        public void UpdatePlayer(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
