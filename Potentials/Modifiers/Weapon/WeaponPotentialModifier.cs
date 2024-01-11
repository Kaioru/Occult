using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers.Weapon;

public abstract class WeaponPotentialModifier : ModPotentialModifier
{
    public virtual void ModifyWeaponDamage(ModPotentialRank rank, Item item, Player player, ref StatModifier damage) {}
    public virtual void ModifyWeaponCrit(ModPotentialRank rank, Item item, Player player, ref float crit) {}
    public virtual void ModifyHitNPC(ModPotentialRank rank, Item item, Player player, NPC target, ref NPC.HitModifiers modifiers) {}
}
