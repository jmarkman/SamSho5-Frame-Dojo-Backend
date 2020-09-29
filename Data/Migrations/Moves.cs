using System;
using System.Collections.Generic;

namespace SamSho5SpcWebApi.Data.Migrations
{
    public partial class Moves
    {
        public long Id { get; set; }
        public long? CharacterId { get; set; }
        public byte[] Name { get; set; }
        public long? Damage { get; set; }
        public long? StartupFrames { get; set; }
        public long? ActiveFrames { get; set; }
        public long? TotalFrames { get; set; }
        public long? CancelWindowStart { get; set; }
        public long? CancelWindowEnd { get; set; }
        public long? LateCancelWindowStart { get; set; }
        public long? LateCancelWindowEnd { get; set; }
        public long? WeaponClashStart { get; set; }
        public long? WeaponClashEnd { get; set; }
        public long? LateWeaponClashStart { get; set; }
        public long? LateWeaponClashEnd { get; set; }
        public long? OnHit { get; set; }
        public long? OnBackhit { get; set; }
        public long? OnBlock { get; set; }
        public long CausesKnockdown { get; set; }
        public long? GuardStance { get; set; }
        public string Notes { get; set; }
    }
}
