using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRankLegendary : ModPotentialRank
{
    public override Color Color => Colors.RarityGreen;

    public override Type UpgradeRank => typeof(PotentialRankTranscendent);
    public override Type DowngradeRank => typeof(PotentialRankUnique);
    
    public override float Multiplier => 4f;
}
