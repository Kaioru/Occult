using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Weapon;

public class WeaponPotentialModifierNonBossDamageR : WeaponPotentialModifier
{
    public override float GetStat(ModPotentialRank rank) 
        => 8f * rank.Multiplier;

    public override void ModifyHitNPC(ModPotentialRank rank, Item item, Player player, NPC target, ref NPC.HitModifiers modifiers)
    {
        if (!target.boss)
            modifiers.NonCritDamage += GetStat(rank) / 100f;
    }
}
