using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Weapon;

public class WeaponPotentialModifierNightDamageR : WeaponPotentialModifier
{
    public override float GetStat(ModPotentialRank rank) 
        => 8f * rank.Multiplier;

    public override void ModifyWeaponDamage(ModPotentialRank rank, Item item, Player player, ref StatModifier damage)
    {
        if (!Main.dayTime)
            damage += GetStat(rank) / 100f;
    }
}
