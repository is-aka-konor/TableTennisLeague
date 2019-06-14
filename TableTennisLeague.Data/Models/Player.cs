using System.Collections.Generic;

namespace TableTennisLeague.Data.Model
{
    public class Player
    {
        public int Id { get; set; }
        
        public double CurrentRank { get; set; }
        public Statistics Results { get; set; }

        public List<Game> GamesA { get; set; }
        public List<Game> GamesB { get; set; }

        public List<Game> Games
        {
            get => GetAllGames(); 
        }
        public string Name { get; set; }

        public Player()
        {

        }
        public Player(string name, double rank)
        {
            CurrentRank = rank;
            Name = name;
        }

        private List<Game> GetAllGames()
        {
            var result = new List<Game>();
            if (GamesA != null)
            {
                result.AddRange(GamesA);    
            }
            if (GamesB != null)
            {
                result.AddRange(GamesB);
            }
            return result;
        }
        
    }
}