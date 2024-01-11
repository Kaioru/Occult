using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Accessory;

public class PotentialModifierLuck : ModPotentialModifier
{
    public override float Value => 1;

    public override void UpdateAccessory(ModPotentialRank rank, Item item, Player player, bool hideVisual)
        => player.luck += Value * rank.Multiplier;
}
