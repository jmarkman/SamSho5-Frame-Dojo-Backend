using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SamSho5SpcWebApi.Data;
using SamSho5SpcWebApi.Data.Models;

namespace SamSho5SpcWebApi.Controllers
{
    [Route("api/moves")]
    [ApiController]
    public class MovesController : ControllerBase
    {
        private readonly SamuraiShodownData _gameData;

        public MovesController(SamuraiShodownData dbLayer)
        {
            _gameData = dbLayer;
        }

        // GET: api/moves
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Move>>> GetMoves()
        {
            return await _gameData.GetAllMovesAsync();
        }

        // GET: api/moves/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Move>> GetMove(int id)
        {
            var move = await _gameData.GetMoveByIdAsync(id);

            if (move == null)
            {
                return NotFound();
            }

            return move;
        }
    }
}
