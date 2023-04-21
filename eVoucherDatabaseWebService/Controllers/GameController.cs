using eVoucherDatabaseWebService_BUS.Services;
using eVoucherDatabaseWebService_DAL.Repositories;
using eVoucherDatabaseWebService_DTO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eVoucherDatabaseWebService.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private GameService _gameService;
        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        // GET: api/<GameController>
        [HttpGet]
        public ActionResult<List<Game>> GetAllGames()
        {
            return Ok(_gameService.GetAllGames());
        }

        // GET api/<GameController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGameByID(int id)
        {
            var game = await _gameService.GetGameById(id);
            if (game == null)
            {
                return NotFound("GameID not found");
            }
            return Ok(game);
        }

        // POST api/<GameController>
        [HttpPost]
        public async Task<ActionResult<Game>> Post([FromBody] Game game)
        {
            if (game == null)
            {
                return BadRequest("Game to add not valid");
            }
            else
            {
                var _game = await _gameService.AddGame(game);
                return Ok(game);
            }
        }

        // PUT api/<GameController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GameController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
