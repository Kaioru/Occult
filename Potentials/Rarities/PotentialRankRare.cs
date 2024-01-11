using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRankRare : ModPotentialRank
{
    public override Color Color => Colors.RarityBlue;

    public override Type UpgradeRank => typeof(PotentialRankEpic);
    public override Type? DowngradeRank => null;
}
