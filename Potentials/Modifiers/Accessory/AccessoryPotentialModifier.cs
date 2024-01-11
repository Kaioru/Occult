using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Accessory;

public abstract class AccessoryPotentialModifier : ModPotentialModifier
{
    public virtual void UpdateAccessory(ModPotentialRank rank, Item item, Player player, bool hideVisual) {}
}
