using System;
using Terraria.ModLoader;

namespace Occult.Items;

public abstract class AbstractItemCube : ModItem
{
    public abstract Type? MinRank { get; }
    public abstract Type? MaxRank { get; }
    
    public abstract float UpgradeRankMultiplier { get; }
    public abstract float DowngradeRankMultiplier { get; }
    public abstract float ModifierUpChance { get; }
}
