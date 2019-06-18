using System.Collections.Generic;

namespace TableTennisLeague.Data.Model
{
    public class Player
    {
        public int Id { get; set; }
        
        public double CurrentRank { get; set; }
        public int Won { get; set; }
        public int WonOverTime { get; set; }
        public int Lost { get; set; }
        public int LostOverTime { get; set; }
        public string Name { get; set; }

        public Player(string name, double rank = 1500D)
        {
            CurrentRank = rank;
            Name = name;
        }

        public Player() { }
    }
}