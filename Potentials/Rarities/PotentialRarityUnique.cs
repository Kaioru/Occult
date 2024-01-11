using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRarityUnique : ModPotentialRarity
{
    public override Color Color => Colors.RarityYellow;

    public override Type? RarityUpgrade => null;
    public override Type RarityDowngrade => typeof(PotentialRarityEpic);
}
