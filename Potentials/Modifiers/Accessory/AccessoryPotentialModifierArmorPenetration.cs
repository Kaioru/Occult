using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Accessory;

public class AccessoryPotentialModifierArmorPenetration : AccessoryPotentialModifier
{
    public override float GetStat(ModPotentialRank rank)
        => 1f * rank.Multiplier;

    public override void UpdateAccessory(ModPotentialRank rank, Item item, Player player, bool hideVisual)
        => player.GetArmorPenetration(DamageClass.Generic) += GetStat(rank);
}
