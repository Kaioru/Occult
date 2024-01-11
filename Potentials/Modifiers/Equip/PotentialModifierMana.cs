using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Equip;

public class PotentialModifierMana : ModPotentialModifier
{
    public override float Value => 2;

    public override void UpdateEquip(ModPotentialRank rank, Item item, Player player)
        => player.statManaMax2 += (int)(Value * rank.Multiplier);
}
