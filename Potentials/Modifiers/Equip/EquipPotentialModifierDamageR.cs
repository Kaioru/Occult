using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Equip;

public class EquipPotentialModifierDamageR : EquipPotentialModifier
{
    public override float GetStat(ModPotentialRank rank)
        => 0.3f * rank.Multiplier;

    public override void UpdateEquip(ModPotentialRank rank, Item item, Player player)
        => player.GetDamage(DamageClass.Generic) += (int)GetStat(rank) / 100f;
}
