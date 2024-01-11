using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Weapon;

public class PotentialModifierDamageR : ModPotentialModifier
{
    public override float Value => 3;
    
    public override void ModifyWeaponDamage(ModPotentialRank rank, Item item, Player player, ref StatModifier damage)
        => damage += Value * rank.Multiplier / 100f;
}
