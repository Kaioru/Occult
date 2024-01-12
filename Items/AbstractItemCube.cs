using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Items;

public abstract class AbstractItemCube : ModItem
{
    public abstract Type? MinRank { get; }
    public abstract Type? MaxRank { get; }
    
    public abstract float UpgradeRankMultiplier { get; }
    public abstract float DowngradeRankMultiplier { get; }
    public abstract float ModifierUpChance { get; }

    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
        tooltips.Add(new TooltipLine(
            Mod,
            $"Upgrade Chance",
            $"{UpgradeRankMultiplier:0.##}x chance of increasing potential rank"));
        tooltips.Add(new TooltipLine(
            Mod,
            $"Downgrade Chance",
            $"{DowngradeRankMultiplier:0.##}x chance of decreasing potential rank"));
        tooltips.Add(new TooltipLine(
            Mod,
            $"Modifier Up Chance",
            $"{ModifierUpChance:0.##}% chance of adding a new modifier"));
    }
}
