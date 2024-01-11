using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Weapon;

public class WeaponPotentialModifierCritDamage : WeaponPotentialModifier
{
    public override float GetStat(ModPotentialRank rank)
        => 6f * rank.Multiplier;

    public override void ModifyHitNPC(ModPotentialRank rank, Item item, Player player, NPC target, ref NPC.HitModifiers modifiers)
        => modifiers.CritDamage += GetStat(rank) / 100f;
}
