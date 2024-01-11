using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Options.Rarities;

public class OptionRarityEpic : ModOptionRarity
{
    public override Color Color => Colors.RarityPurple;
    
    public override Type RarityUpgrade => typeof(OptionRarityUnique);
    public override Type RarityDowngrade => typeof(OptionRarityRare);
}
