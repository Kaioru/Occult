using System;

namespace Occult.Potentials;

public interface PotentialStrategy
{
    Type? MaxRank { get; }
    
    float UpgradeRankMultiplier { get; }
    float DowngradeRankMultiplier { get; }
    float ModifierUpChance { get; }
}
