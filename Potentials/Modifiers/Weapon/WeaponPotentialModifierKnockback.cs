using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Weapon;

public class WeaponPotentialModifierKnockback : WeaponPotentialModifier
{
    public override float GetStat(ModPotentialRank rank) 
        => 1f * rank.Multiplier;

    public override void ModifyWeaponKnockback(ModPotentialRank rank, Item item, Player player, ref StatModifier knockback)
        => knockback.Flat += GetStat(rank);
}
