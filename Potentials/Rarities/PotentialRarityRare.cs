using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRarityRare : ModPotentialRarity
{
    public override Color Color => Colors.RarityBlue;

    public override Type RarityUpgrade => typeof(PotentialRarityEpic);
    public override Type? RarityDowngrade => null;
}
