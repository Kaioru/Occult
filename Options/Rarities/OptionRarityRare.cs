using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Options.Rarities;

public class OptionRarityRare : ModOptionRarity
{
    public override Color Color => Colors.RarityBlue;

    public override Type RarityUpgrade => typeof(OptionRarityEpic);
    public override Type? RarityDowngrade => null;
}
