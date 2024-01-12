using Terraria;

namespace Occult.Potentials.Modifiers.Weapon;

public abstract class WeaponPotentialModifier : ModPotentialModifier
{
    public override ModPotentialType Type => ModPotentialType.Weapon;

    public override bool CanRoll(Item item)
        => item is { maxStack: 1, damage: > 0 };
}
