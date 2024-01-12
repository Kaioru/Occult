using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Accessory;

public class AccessoryPotentialModifierAttackSpeed : AccessoryPotentialModifier
{
    public override float GetStat(ModPotentialRank rank)
        => 0.5f * rank.Multiplier;

    public override void UpdateAccessory(ModPotentialRank rank, Item item, Player player, bool hideVisual)
        => player.GetAttackSpeed(DamageClass.Generic) += GetStat(rank) / 100f;
}
