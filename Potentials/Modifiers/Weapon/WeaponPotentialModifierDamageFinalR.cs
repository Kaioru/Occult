using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Weapon;

public class WeaponPotentialModifierDamageFinalR : WeaponPotentialModifier
{
    public override float GetStat(ModPotentialRank rank) 
        => 0.5f * rank.Multiplier;

    public override void ModifyWeaponDamage(ModPotentialRank rank, Item item, Player player, ref StatModifier damage)
        => damage *= 1 + GetStat(rank) / 100f;
}
