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
        PrettyPrintName
    );

    public virtual int Value { get; } = 0;
    
    protected override sealed void Register()
    {
        ModTypeLookup<ModPotentialModifier>.Register(this);
    }
    public virtual void ModifyWeaponDamage(ModPotentialRank rank, Item item, Player player, ref StatModifier damage) {}
}