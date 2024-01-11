using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Equip;

public class EquipPotentialModifierDefense : EquipPotentialModifier
{
    public override float GetStat(ModPotentialRank rank)
        => 1f * rank.Multiplier;

    public override void UpdateEquip(ModPotentialRank rank, Item item, Player player)
        => player.statDefense += (int)GetStat(rank);
}
