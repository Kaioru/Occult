using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Equip;

public class EquipPotentialModifierMana : EquipPotentialModifier
{
    public override float GetStat(ModPotentialRank rank)
        => 2f * rank.Multiplier;
    
    public override void UpdateEquip(ModPotentialRank rank, Item item, Player player)
        => player.statManaMax2 += (int)GetStat(rank);
}
