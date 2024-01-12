using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRankRare : ModPotentialRank
{
    public override Color Color => Colors.RarityBlue;

    public override Type UpgradeRank => typeof(PotentialRankEpic);
    public override float UpgradeRankChance => 12f;
    public override Type? DowngradeRank => null;
    public override float DowngradeRankChance => 0;

    public override float Multiplier => 1f;
}
