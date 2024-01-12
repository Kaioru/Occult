using System;
using Occult.Potentials.Rarities;

namespace Occult.Items;

public class ItemCubePrototype : AbstractItemCube
{
    public override Type? MaxRank => typeof(PotentialRankEpic);
    public override float UpgradeRankMultiplier => 1f;
    public override float DowngradeRankMultiplier => 1f;
    public override float ModifierUpChance => 0.06f;
}
