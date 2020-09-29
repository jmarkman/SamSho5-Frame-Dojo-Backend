using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SamSho5SpcWebApi.Data.Models
{
    public class Character
    {
        /// <summary>
        /// The numeric ID for this character. Primary key.
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The character's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A summary of the character's playstyle, strengths, and weaknesses
        /// </summary>
        public string GameplayDetails { get; set; }

        /// <summary>
        /// Information about how the character fits into the world of Samurai
        /// Shodown, along with any other trivia about the character
        /// </summary>
        public string Lore { get; set; }

        /// <summary>
        /// A list containing all of the moves associated with the current character
        /// </summary>
        public virtual List<Move> Moves { get; set; }

        public Character()
        {

        }
    }
}
