using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRankUnique : ModPotentialRank
{
    public override Color Color => Colors.RarityYellow;

    public override Type? UpgradeRank => null;
    public override Type DowngradeRank => typeof(PotentialRankEpic);
}
