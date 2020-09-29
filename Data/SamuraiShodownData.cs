using Microsoft.EntityFrameworkCore;
using SamSho5SpcWebApi.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamSho5SpcWebApi.Data
{
    public class SamuraiShodownData
    {
        private readonly SamShoDbContext _samshoDbContext;

        public SamuraiShodownData(SamShoDbContext db)
        {
            _samshoDbContext = db;
        }

        /// <summary>
        /// Retrieves all characters from the database
        /// </summary>
        /// <returns>A list of all <see cref="Character"/> objects that exist in the database</returns>
        public async Task<List<Character>> GetAllCharactersAsync()
        {
            return await _samshoDbContext.Characters.ToListAsync();
        }

        /// <summary>
        /// Retrieves a character from the database specified by its numeric id
        /// </summary>
        /// <param name="id">The character's id number in the database</param>
        /// <returns>A <see cref="Character"/> object representing the character with the specified id</returns>
        public async Task<Character> GetCharacterAsync(int id)
        {
            return await _samshoDbContext.Characters.FindAsync(id);
        }

        /// <summary>
        /// Retrieves a character from the database specified by the character's name.
        /// The character's name must be an exact match spelling-wise but isn't case-sensitive
        /// </summary>
        /// <param name="characterName">The name of the character</param>
        /// <returns>A <see cref="Character"/> object representing the character with the specified name</returns>
        public async Task<Character> GetCharacterByNameAsync(string characterName)
        {
            return await _samshoDbContext.Characters
                                    .Where(c => c.Name.ToLower() == characterName.ToLower())
                                    .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Retrieves a character and their moveset from the database, with the character being
        /// specified by name. The character's name must be an exact match spelling-wise but
        /// isn't case-sensitive
        /// </summary>
        /// <param name="characterName">The name of the character</param>
        /// <returns>A <see cref="Character"/> object representing the character and their complete moveset with the specified name</returns>
        public async Task<Character> GetCharacterWithMovesByNameAsync(string characterName)
        {
            return await _samshoDbContext.Characters
                                .Include(m => m.Moves)
                                .SingleOrDefaultAsync(i => i.Name.ToLower() == characterName.ToLower());
        }

        /// <summary>
        /// Retrieves all character moves in the database
        /// </summary>
        /// <returns>A list of <see cref="Move"/> objects representing all of the moves in the database</returns>
        public async Task<List<Move>> GetAllMovesAsync()
        {
            return await _samshoDbContext.Moves.ToListAsync();
        }

        /// <summary>
        /// Retrieves a specific move from the database associated with the provided id
        /// </summary>
        /// <param name="id">The id number associated with the desired move</param>
        /// <returns>A <see cref="Move"/> object representing the move associated with the provided id</returns>
        public async Task<Move> GetMoveByIdAsync(int id)
        {
            return await _samshoDbContext.Moves.FindAsync(id);
        }
    }
}
