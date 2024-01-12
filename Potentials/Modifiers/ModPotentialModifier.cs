using Occult.Potentials.Rarities;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers;

public abstract class ModPotentialModifier : ModType, ILocalizedModType
{
    public string LocalizationCategory => "PotentialModifiers";
    
    public virtual LocalizedText Tooltip => this.GetLocalization(
        nameof(Tooltip), 
        () => "+{0} " + PrettyPrintName()
    );
    
    public abstract ModPotentialType Type { get; }

    protected override sealed void Register()
    {
        ModTypeLookup<ModPotentialModifier>.Register(this);
    }

    public virtual bool CanRoll(Item item) => false;
    public virtual float GetStat(ModPotentialRank rank) => 0;
    
    public virtual void UpdateAccessory(ModPotentialRank rank, Item item, Player player, bool hideVisual) {}
    public virtual void UpdateEquip(ModPotentialRank rank, Item item, Player player) {}

    public virtual void ModifyWeaponDamage(ModPotentialRank rank, Item item, Player player, ref StatModifier damage) {}
    public virtual void ModifyWeaponCrit(ModPotentialRank rank, Item item, Player player, ref float crit) {}
    public virtual void ModifyHitNPC(ModPotentialRank rank, Item item, Player player, NPC target, ref NPC.HitModifiers modifiers) {}
    public virtual void ModifyWeaponKnockback(ModPotentialRank potentialsRank, Item item, Player player, ref StatModifier knockback) {}
}