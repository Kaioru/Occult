using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRankTranscendent : ModPotentialRank
{
    public override Color Color => Colors.RarityRed;

    public override Type? UpgradeRank => null;
    public override Type DowngradeRank => typeof(PotentialRankLegendary);
    
    public override float Multiplier => 5f;
}