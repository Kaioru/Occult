using System.Collections.Generic;
using System.Linq;
using Occult.Potentials.Modifiers;
using Occult.Potentials.Modifiers.Accessory;
using Occult.Potentials.Modifiers.Equip;
using Occult.Potentials.Modifiers.Weapon;
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
            Rank = Mod.Find<ModPotentialRank>(nameof(PotentialRankUnique)),
            Modifiers = new List<ModPotentialModifier>()
        };

        Potentials.Modifiers.Add(Mod.Find<ModPotentialModifier>(nameof(WeaponPotentialModifierDamageFinalR)));
        Potentials.Modifiers.Add(Mod.Find<ModPotentialModifier>(nameof(WeaponPotentialModifierDamageFinalR)));
        Potentials.Modifiers.Add(Mod.Find<ModPotentialModifier>(nameof(WeaponPotentialModifierDamageFinalR)));
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
                            .WithFormatArgs(modifier.GetStat(Potentials.Rank).ToString("0.##"))
                            .ToString())
                    {
                        IsModifier = true,
                        IsModifierBad = false
                    }
                );
            }
        }
    }

    public override void UpdateEquip(Item item, Player player)
    {
        if (Potentials != null)
            foreach (var modifier in Potentials.Modifiers)
                if (modifier is EquipPotentialModifier equipModifier)
                    equipModifier.UpdateEquip(Potentials.Rank, item, player);
        base.UpdateEquip(item, player);
    }

    public override void UpdateAccessory(Item item, Player player, bool hideVisual)
    {
        if (Potentials != null)
            foreach (var modifier in Potentials.Modifiers)
                if (modifier is AccessoryPotentialModifier accessoryModifier)
                    accessoryModifier.UpdateAccessory(Potentials.Rank, item, player, hideVisual);
        base.UpdateAccessory(item, player, hideVisual);
    }

    public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage)
    {
        if (Potentials != null)
            foreach (var modifier in Potentials.Modifiers)
                if (modifier is WeaponPotentialModifier weaponPotential)
                    weaponPotential.ModifyWeaponDamage(Potentials.Rank, item, player, ref damage);
        base.ModifyWeaponDamage(item, player, ref damage);
    }

    public override void ModifyWeaponCrit(Item item, Player player, ref float crit)
    {
        if (Potentials != null)
            foreach (var modifier in Potentials.Modifiers)
                if (modifier is WeaponPotentialModifier weaponPotential)
                    weaponPotential.ModifyWeaponCrit(Potentials.Rank, item, player, ref crit);
        base.ModifyWeaponCrit(item, player, ref crit);
    }

    public override void ModifyHitNPC(Item item, Player player, NPC target, ref NPC.HitModifiers modifiers)
    {
        if (Potentials != null)
            foreach (var modifier in Potentials.Modifiers)
                if (modifier is WeaponPotentialModifier weaponPotential)
                    weaponPotential.ModifyHitNPC(Potentials.Rank, item, player, target, ref modifiers);
        base.ModifyHitNPC(item, player, target, ref modifiers);
    }
}
