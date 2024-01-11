using System.Collections.Generic;
using Occult.Potentials.Modifiers;
using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials;

public class PotentialItem : GlobalItem
{
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        base.ModifyTooltips(item, tooltips);

        var rank = Mod.Find<ModPotentialRank>(nameof(PotentialRankRare));
        var modifier1 = Mod.Find<ModPotentialModifier>(nameof(PotentialModifierTest));
        
        tooltips.Add(new TooltipLine(Occult.Instance, "Occult:ItemPotentialRank", rank.DisplayName.Value));
        tooltips.Add(new TooltipLine(Occult.Instance, "Occult:ItemPotential1", modifier1.Tooltip.Value));
    }
}
