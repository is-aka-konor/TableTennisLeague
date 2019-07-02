using System;
using System.Collections.Generic;
using System.Text;
using TableTennisLeague.Data.Interfaces;
using TableTennisLeague.Data.Models;

namespace TableTennisLeague.Data.Repositories
{
    public class LeagueRepository
    {
        private readonly ISQLiteConnectionFactory _connectionFactory;
        public LeagueRepository(ISQLiteConnectionFactory connectionFactory)
        {
            this._connectionFactory = connectionFactory;
        }

        public League GetLeague(int LeagueId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<League> GetLeagues()
        {
            throw new NotImplementedException();
        }

        public void CreateLeague(League League)
        {
            throw new NotImplementedException();
        }

        public void UpdateLeague(League League)
        {
            throw new NotImplementedException();
        }

        public void DeleteLeague(int LeagueId)
        {
            throw new NotImplementedException();
        }
    }
}
