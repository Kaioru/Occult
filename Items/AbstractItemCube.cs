using System;
using System.Collections.Generic;
using Occult.Potentials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Occult.Items;

public abstract class AbstractItemCube : ModItem, PotentialStrategy
{
    public abstract Type? MaxRank { get; }
    public abstract float UpgradeRankMultiplier { get; }
    public abstract float DowngradeRankMultiplier { get; }
    public abstract float ModifierUpChance { get; }

    public override void SetDefaults()
    {
        Item.maxStack = 9999;
        Item.useStyle = ItemUseStyleID.HiddenAnimation;
        Item.UseSound = SoundID.Item1;
    }
    public override bool? UseItem(Player player)
    {
        // TODO
        return true;
    }

    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
        tooltips.Add(new TooltipLine(
            Mod,
            "Upgrade Chance",
            $"{UpgradeRankMultiplier:0.##}x chance of increasing potential rank"));
        tooltips.Add(new TooltipLine(
            Mod,
            "Downgrade Chance",
            $"{DowngradeRankMultiplier:0.##}x chance of decreasing potential rank"));
        tooltips.Add(new TooltipLine(
            Mod,
            "Modifier Up Chance",
            $"{ModifierUpChance:0.##}% chance of adding a new modifier"));
    }

}
