using System.Collections.Generic;
using System;
namespace TableTennisLeague.Data.Models
{
    public class Season
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<League> Leagues { get; set; }
    }
}