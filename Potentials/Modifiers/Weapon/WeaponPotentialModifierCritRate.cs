using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Weapon;

public class WeaponPotentialModifierCritRate : WeaponPotentialModifier
{
    public override float GetStat(ModPotentialRank rank)
        => 3f * rank.Multiplier;

    public override void ModifyWeaponCrit(ModPotentialRank rank, Item item, Player player, ref float crit)
        => crit += GetStat(rank);
}
