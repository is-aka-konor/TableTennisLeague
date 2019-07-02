using System.Collections.Generic;

namespace TableTennisLeague.Data.Models
{
    public class League
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Game> Games { get; set; }
    }
}