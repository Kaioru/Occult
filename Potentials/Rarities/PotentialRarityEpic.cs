using System;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Occult.Potentials.Rarities;

public class PotentialRarityEpic : ModPotentialRarity
{
    public override Color Color => Colors.RarityPurple;
    
    public override Type RarityUpgrade => typeof(PotentialRarityUnique);
    public override Type RarityDowngrade => typeof(PotentialRarityRare);
}
