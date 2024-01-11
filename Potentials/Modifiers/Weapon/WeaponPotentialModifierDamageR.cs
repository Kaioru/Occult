using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Weapon;

public class WeaponPotentialModifierDamageR : WeaponPotentialModifier
{
    public override float GetStat(ModPotentialRank rank) 
        => 3f * rank.Multiplier;

    public override void ModifyWeaponDamage(ModPotentialRank rank, Item item, Player player, ref StatModifier damage)
        => damage += GetStat(rank) / 100f;
}
