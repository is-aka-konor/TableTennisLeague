using System.Collections.Generic;
using TableTennisLeague.Data.Models;

namespace TableTennisLeague.Data.Interfaces
{
    public interface IGameRepository
    {
        GameViewModel GetGame(int gameId);
        IEnumerable<GameViewModel> GetAllGames();
        IEnumerable<GameViewModel> GetGamesForPlayer(int playerId);
        IEnumerable<GameViewModel> GetGamesForLeague(int leagueId);
        IEnumerable<GameViewModel> GetGamesForSeason(int seasonId);
        Game CreateGame(Game game);
        Game UpdateGame(Game game);
        void DeleteGame(int gameId);
    }
}