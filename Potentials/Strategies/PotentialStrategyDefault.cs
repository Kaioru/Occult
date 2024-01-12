using System;
using Occult.Potentials.Rarities;

namespace Occult.Potentials.Strategies;

public class PotentialStrategyDefault : PotentialStrategy
{
    private readonly bool _hardmode;
    
    public PotentialStrategyDefault(bool hardmode)
    {
        _hardmode = hardmode;
    }
    
    public Type MaxRank => typeof(PotentialRankEpic);
    public float UpgradeRankMultiplier => _hardmode ? 3f : 1.5f;
    public float DowngradeRankMultiplier => 0f;
    public float ModifierUpChance => 0.2f;
}
