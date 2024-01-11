using Occult.Potentials.Rarities;
using Terraria;

namespace Occult.Potentials.Modifiers.Equip;

public abstract class EquipPotentialModifier : ModPotentialModifier
{
    public virtual void UpdateEquip(ModPotentialRank rank, Item item, Player player) {}
}
