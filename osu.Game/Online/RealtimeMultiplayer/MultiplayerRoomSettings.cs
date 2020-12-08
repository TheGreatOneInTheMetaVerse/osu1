// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using osu.Game.Online.API;

namespace osu.Game.Online.RealtimeMultiplayer
{
    public class MultiplayerRoomSettings : IEquatable<MultiplayerRoomSettings>
    {
        public int? BeatmapID { get; set; }

        public int? RulesetID { get; set; }

        [NotNull]
        public IEnumerable<APIMod> Mods { get; set; } = Enumerable.Empty<APIMod>();

        public bool Equals(MultiplayerRoomSettings other) => BeatmapID == other?.BeatmapID && Mods.SequenceEqual(other?.Mods) && RulesetID == other?.RulesetID;

        public override string ToString() => $"Beatmap:{BeatmapID} Mods:{string.Join(',', Mods)} Ruleset:{RulesetID}";
    }
}
