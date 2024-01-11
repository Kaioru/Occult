using System.Collections.Generic;
using System.Linq;
using Occult.Potentials.Modifiers;
using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Occult.Potentials;

public class PotentialItem : GlobalItem
{
    public override bool InstancePerEntity => true;

    public PotentialPool? Potentials { get; set; }

    public override void SetDefaults(Item entity)
    {
        Potentials = new PotentialPool
        {
            Rank = Mod.Find<ModPotentialRank>(nameof(PotentialRankEpic))
        };

        Potentials.Modifiers = new List<ModPotentialModifier>();
        Potentials.Modifiers.Add(Mod.Find<ModPotentialModifier>(nameof(PotentialModifierDamageR)));
        Potentials.Modifiers.Add(Mod.Find<ModPotentialModifier>(nameof(PotentialModifierDamageR)));
        Potentials.Modifiers.Add(Mod.Find<ModPotentialModifier>(nameof(PotentialModifierDamageR)));
    }
    
    public override void LoadData(Item item, TagCompound tag)
    {
        Potentials = PotentialPool.Load(Mod, tag);
    }

    public override void SaveData(Item item, TagCompound tag)
    {
        PotentialPool.Save(Potentials, tag);
    }
    
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (Potentials != null)
        {
            tooltips.Add(
                new TooltipLine(
                    Mod,
                    "ItemPotentialRank",
                    Potentials.Rank.DisplayName.ToString())
                {
                    OverrideColor = Potentials.Rank.Color,
                }
            );

            foreach (var (i, modifier) in Potentials.Modifiers.Select((e, i) => (i, e)))
            {
                tooltips.Add(
                    new TooltipLine(
                        Mod,
                        $"ItemPotentialModifier{i}",
                        modifier.Tooltip
                            .WithFormatArgs(modifier.Value * Potentials.Rank.Multiplier)
                            .ToString())
                    {
                        IsModifier = true,
                        IsModifierBad = false
                    }
                );
            }
        }
    }

    public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage)
    {
        if (Potentials != null)
            foreach (var modifier in Potentials.Modifiers)
                modifier.ModifyWeaponDamage(Potentials.Rank, item, player, ref damage);
        base.ModifyWeaponDamage(item, player, ref damage);
    }
}
