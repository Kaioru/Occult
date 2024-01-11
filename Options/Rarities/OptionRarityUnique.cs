using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Options.Rarities;

public class OptionRarityUnique : ModOptionRarity
{
    public override Color Color => Colors.RarityYellow;

    public override Type? RarityUpgrade => null;
    public override Type RarityDowngrade => typeof(OptionRarityEpic);
}
