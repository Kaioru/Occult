using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Weapon;

public class PotentialModifierNightDamageR : ModPotentialModifier
{
    public override float Value => 6;
    
    public override void ModifyWeaponDamage(ModPotentialRank rank, Item item, Player player, ref StatModifier damage)
    {
        if (!Main.dayTime)
            damage += Value * rank.Multiplier / 100f;
    }
}
