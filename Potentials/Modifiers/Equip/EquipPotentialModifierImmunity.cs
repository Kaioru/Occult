using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Equip;

public class EquipPotentialModifierImmunity : EquipPotentialModifier
{
    public override float GetStat(ModPotentialRank rank)
        => 1f * rank.Multiplier;

    public override void UpdateEquip(ModPotentialRank rank, Item item, Player player)
        => player.immuneTime += (int)GetStat(rank);
}
