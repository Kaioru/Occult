using System;
using Occult.Potentials.Rarities;

namespace Occult.Items;

public class ItemCubeOccult : AbstractItemCube
{
    public override Type MaxRank => typeof(PotentialRankLegendary);
    public override float UpgradeRankMultiplier => 2f;
    public override float DowngradeRankMultiplier => 0.5f;
    public override float ModifierUpChance => 0.10f;
}
