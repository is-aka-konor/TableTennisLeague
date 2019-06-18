using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TableTennisLeague.Data.Interfaces;
using TableTennisLeague.Data.Model;

namespace TableTennisLeague.SPA.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    public class PlayersController: Controller
    {
        private readonly IPlayerRepository _playerRepository;
        
        public PlayersController(IPlayerRepository playerRepository)
        {
            this._playerRepository = playerRepository;
        }

        [HttpGet]
        public IEnumerable<Player> Players(int playerId)
        {
            if (playerId > 0)
            {
                return new List<Player>() { this._playerRepository.GetPlayer(playerId) };
            }
            var players = this._playerRepository.GetPlayers();
            return players;
        }

        [HttpPost]
        public IActionResult CreatePlayer([FromBody]Player player)
        {
            if(player == null)
            {
                return BadRequest();
            }
            this._playerRepository.InsertPlayer(player);
            return Created("", player);
        }
    }
}