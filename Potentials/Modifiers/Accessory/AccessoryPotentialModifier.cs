using Terraria;

namespace Occult.Potentials.Modifiers.Accessory;

public abstract class AccessoryPotentialModifier : ModPotentialModifier
{
    public override ModPotentialType Type => ModPotentialType.Accessory;

    public override bool CanRoll(Item item)
        => item.maxStack == 1 && item is { accessory: true, vanity: false };
}
