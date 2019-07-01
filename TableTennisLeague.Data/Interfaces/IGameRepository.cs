using System.Collections.Generic;
using TableTennisLeague.Data.Model;

namespace TableTennisLeague.Data.Interfaces
{
    public interface IGameRepository
    {
        Game GetGame(int gameId);
        IEnumerable<Game> GetAllGames();
        IEnumerable<Game> GetGamesForPlayer(int playerId);
        IEnumerable<Game> GetGamesForLeague(int leagueId);
        IEnumerable<Game> GetGamesForSeason(int seasonId);
        Game CreateGame(Game game);
        Game UpdateGame(Game game);
        void DeleteGame(int gameId);
    }
}