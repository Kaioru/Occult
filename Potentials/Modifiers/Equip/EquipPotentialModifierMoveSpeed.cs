using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Equip;

public class EquipPotentialModifierMoveSpeed : EquipPotentialModifier
{
    public override float GetStat(ModPotentialRank rank)
        => 5f * rank.Multiplier;
    
    public override void UpdateEquip(ModPotentialRank rank, Item item, Player player)
        => player.moveSpeed += (int)GetStat(rank);
}
