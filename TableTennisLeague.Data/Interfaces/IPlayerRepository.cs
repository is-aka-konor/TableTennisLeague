using System;
using System.Collections.Generic;
using TableTennisLeague.Data.Model;

namespace TableTennisLeague.Data.Interfaces
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetPlayers();
        IEnumerable<Player> GetPlayers(int leagueId);
        Player GetPlayer(int id);
        void InsertPlayer(Player player);
        void UpdatePlayer(Player player);
    }
}