using Microsoft.AspNetCore.Mvc;
using TableTennisLeague.Data.Interfaces;

namespace TableTennisLeague.SPA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameRepository _gameRepository;

        public GamesController(IGameRepository gameRepository)
        {
            this._gameRepository = gameRepository;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetGame(int gameId)
        {
            return NotFound();
        }

        [HttpGet]
        public IActionResult GetAllGames()
        {
            var result = this._gameRepository.GetAllGames();
            if(result == null) return NotFound();

            return Ok(result);
        }
    }
}