using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRankLegendary : ModPotentialRank
{
    public override Color Color => Colors.RarityGreen;

    public override Type UpgradeRank => typeof(PotentialRankTranscendent);
    public override float UpgradeRankChance => 0.04f;
    public override Type DowngradeRank => typeof(PotentialRankUnique);
    public override float DowngradeRankChance => 0.06f;

    public override float Multiplier => 4f;
}
