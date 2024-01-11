using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Weapon;

public class PotentialModifierDamageFinalR : ModPotentialModifier
{
    public override float Value => 0.5f;
    
    public override void ModifyWeaponDamage(ModPotentialRank rank, Item item, Player player, ref StatModifier damage)
        => damage *= 1 + Value * rank.Multiplier / 10f;
}
