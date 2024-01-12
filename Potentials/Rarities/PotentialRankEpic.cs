using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRankEpic : ModPotentialRank
{
    public override Color Color => Colors.RarityPurple;
    
    public override Type UpgradeRank => typeof(PotentialRankUnique);
    public override float UpgradeRankChance => 0.08f;
    public override Type DowngradeRank => typeof(PotentialRankRare);
    public override float DowngradeRankChance => 0.06f;

    public override float Multiplier => 2f;
}
