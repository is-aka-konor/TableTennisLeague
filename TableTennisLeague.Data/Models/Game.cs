namespace TableTennisLeague.Data.Model
{
    public class Game
    {
        public int Id { get; set; }

        public int LeagueId { get; set; }

        public int? PlayerAid { get; set; }
        public int? PlayerBid { get; set; }

        public Player PlayerA { get; set; }
        public Player PlayerB { get; set; }

        public int ResultA { get; set; }
        public int ResultB { get; set; }

        public Game() { }

        public Game(Player a, Player b)
        {
            PlayerA = a;
            PlayerB = b;
        }

        public Game(int leagueId,  Player a, Player b) : this (a, b)
        {
            LeagueId = leagueId;
        }

        public void AddResult(int resultA, int resultB)
        {
            this.ResultA = resultA;
            this.ResultB = resultB;
        }
    }
}
