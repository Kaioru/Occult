using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRankUnique : ModPotentialRank
{
    public override Color Color => Colors.RarityYellow;

    public override Type UpgradeRank => typeof(PotentialRankLegendary);
    public override float UpgradeRankChance => 0.06f;
    public override Type DowngradeRank => typeof(PotentialRankEpic);
    public override float DowngradeRankChance => 0.06f;

    public override float Multiplier => 3f;
}
