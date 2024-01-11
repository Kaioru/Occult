using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace Occult;

public class OccultGlobalItem : GlobalItem
{
    
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        base.ModifyTooltips(item, tooltips);
        
        tooltips.Add(new TooltipLine(Occult.Instance, "Occult:ItemOptionRank", "Unique Potential"));
        tooltips.Add(new TooltipLine(Occult.Instance, "Occult:ItemOption1", "+5% Damage"));
        tooltips.Add(new TooltipLine(Occult.Instance, "Occult:ItemOption2", "+10% Damage when below 50% health"));
        tooltips.Add(new TooltipLine(Occult.Instance, "Occult:ItemOption3", "+10% Damage during night time"));
    }
}
