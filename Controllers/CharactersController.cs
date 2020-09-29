using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SamSho5SpcWebApi.Data;
using SamSho5SpcWebApi.Data.Models;

namespace SamSho5SpcWebApi.Controllers
{
    [Route("api/characters")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly SamuraiShodownData _gameData;

        public CharactersController(SamuraiShodownData dbLayer)
        {
            _gameData = dbLayer;
        }

        // GET: api/characters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Character>>> GetCharacters()
        {
            return await _gameData.GetAllCharactersAsync();
        }

        // GET: api/characters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            var character = await _gameData.GetCharacterAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            return character;
        }

        [HttpGet("complete/{name}")]
        public async Task<ActionResult<Character>> GetCharacterWithMovesByName(string name)
        {
            var completeCharacter = await _gameData.GetCharacterWithMovesByNameAsync(name);

            if (completeCharacter == null)
            {
                return NotFound();
            }

            return completeCharacter;
        }
    }
}
