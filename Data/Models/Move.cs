using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamSho5SpcWebApi.Data.Models
{
    public class Move
    {
        /// <summary>
        /// Unique ID for this move
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The character that has this move
        /// </summary>
        [ForeignKey("Character")]
        public int CharacterId { get; set; }

        /// <summary>
        /// The name of the move and/or its input
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The base damage of the move
        /// </summary>
        public int? Damage { get; set; }

        /// <summary>
        /// The number of frames it takes for the animation to reach its "damaging" state
        /// </summary>
        public int? StartupFrames { get; set; }

        /// <summary>
        /// The frames of the move animation that will result in damage
        /// </summary>
        public int? ActiveFrames { get; set; }

        /// <summary>
        /// The total number of frames in the move, including startup, active, and ending
        /// </summary>
        public int? TotalFrames { get; set; }

        /// <summary>
        /// The first frame in the animation where the move can have the rest of its 
        /// animation cancelled into another move
        /// </summary>
        public int? CancelWindowStart { get; set; }

        /// <summary>
        /// The last frame in the animation where the move can have the rest of its
        /// animation cancelled into another move
        /// </summary>
        public int? CancelWindowEnd { get; set; }

        /// <summary>
        /// Some moves have two windows where they can be cancelled into another move,
        /// usually later into the move's animation. This is the first frame where this
        /// cancel is possible.
        /// </summary>
        public int? LateCancelWindowStart { get; set; }

        /// <summary>
        /// Some moves have two windows where they can be cancelled into another move,
        /// usually later into the move's animation. This is the last frame where this
        /// cancel is possible.
        /// </summary>
        public int? LateCancelWindowEnd { get; set; }

        /// <summary>
        /// The first frame in a move's animation where it can meet the opponent's weapon
        /// swing and start a clash minigame to disarm one player
        /// </summary>
        public int? WeaponClashStart { get; set; }

        /// <summary>
        /// The last frame in a move's animation where it can meet the opponent's weapon
        /// swing and start a clash minigame to disarm one player 
        /// </summary>
        public int? WeaponClashEnd { get; set; }

        /// <summary>
        /// Some moves have two windows where they can clash with weapons. This is the first 
        /// frame where the clash is possible.
        /// </summary>
        public int? LateWeaponClashStart { get; set; }

        /// <summary>
        /// Some moves have two windows where they can clash with weapons. This is the last 
        /// frame where the clash is possible.
        /// </summary>
        public int? LateWeaponClashEnd { get; set; }

        /// <summary>
        /// The frame advantage bestowed onto the player using this move if the move
        /// damages the enemy
        /// </summary>
        public int? OnHit { get; set; }

        /// <summary>
        /// The frame advantage bestowed onto the player using this move if the move results
        /// in a backhit on the opponent
        /// </summary>
        public int? OnBackhit { get; set; }

        /// <summary>
        /// The frame advantage bestowed onto the player using this move if the move is blocked
        /// by the opponent
        /// </summary>
        public int? OnBlock { get; set; }

        /// <summary>
        /// If this move hits, will it knock the opponent down on the ground?
        /// </summary>
        public bool CausesKnockdown { get; set; }

        /// <summary>
        /// The guard stance level that has to be used in order to block this move
        /// Low - hold down and back to block
        /// Mid and High - hold back to block
        /// </summary>
        public GuardStanceLevel GuardStance { get; set; }

        /// <summary>
        /// Any assorted factoids about the move
        /// </summary>
        public string Notes { get; set; }

        public Move()
        {

        }
    }
}
