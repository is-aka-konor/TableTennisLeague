using System;
namespace TableTennisLeague.Data.Models
{
    public class GameViewModel
    {
        public int LeagueId { get; set; }
        public int SeasonId { get; set; }
        public int GameId { get; set; }
        public string GameDate { get; set; }
        public int PlayerAId { get; set; }
        public int PlayerBId { get; set; }
        public string PlayerAName { get; set; }
        public string PlayerBName { get; set; }
        public int ResultPlayerA { get; set; }
        public int ResultPlayerB { get; set; }
    }
}
