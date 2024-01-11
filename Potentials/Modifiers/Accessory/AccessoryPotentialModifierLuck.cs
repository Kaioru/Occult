using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Accessory;

public class AccessoryPotentialModifierLuck : AccessoryPotentialModifier
{
    public override float GetStat(ModPotentialRank rank)
        => 0.5f * rank.Multiplier;

    public override void UpdateAccessory(ModPotentialRank rank, Item item, Player player, bool hideVisual)
        => player.luck += GetStat(rank);
}
