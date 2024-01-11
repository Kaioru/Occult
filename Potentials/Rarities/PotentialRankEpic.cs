using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRankEpic : ModPotentialRank
{
    public override Color Color => Colors.RarityPurple;
    
    public override Type UpgradeRank => typeof(PotentialRankUnique);
    public override Type DowngradeRank => typeof(PotentialRankRare);
}
