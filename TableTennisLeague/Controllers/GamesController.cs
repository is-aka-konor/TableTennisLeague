using Microsoft.AspNetCore.Mvc;
using TableTennisLeague.Data.Interfaces;

namespace TableTennisLeague.SPA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ISQLiteConnectionFactory _connectionFactory;

        public GamesController(ISQLiteConnectionFactory connectionFactory)
        {
            this._connectionFactory = connectionFactory;
        }

        [HttpGet]
        public IActionResult GetGame(int gameId)
        {
            return NotFound();
        }
    }
}