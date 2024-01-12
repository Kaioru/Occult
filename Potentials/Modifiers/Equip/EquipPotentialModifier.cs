using Terraria;

namespace Occult.Potentials.Modifiers.Equip;

public abstract class EquipPotentialModifier : ModPotentialModifier
{
    public override ModPotentialType Type => ModPotentialType.Equip;
    
    public override bool CanRoll(Item item)
        => item.maxStack == 1 && (item.headSlot >= 0 || item.bodySlot >= 0 || item.legSlot >= 0) && !item.vanity;
}
