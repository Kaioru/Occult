using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Equip;

public class PotentialModifierDefense : ModPotentialModifier
{
    public override float Value => 1;

    public override void UpdateEquip(ModPotentialRank rank, Item item, Player player)
        => player.statDefense += (int)(Value * rank.Multiplier);
}
