using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TableTennisLeague.Data.Interfaces;

namespace TableTennisLeague.SPA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaguesController : ControllerBase
    {
        private readonly ISQLiteConnectionFactory _connectionFactory;

        public LeaguesController(ISQLiteConnectionFactory connectionFactory)
        {
            this._connectionFactory = connectionFactory;
        }
    }
}