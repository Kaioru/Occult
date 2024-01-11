using Terraria.Localization;
using Terraria.ModLoader;

namespace Occult.Potentials.Modifiers;

public class ModPotentialModifier : ModType, ILocalizedModType
{
    public string LocalizationCategory => "PotentialModifiers";
    
    public virtual LocalizedText Tooltip => this.GetLocalization(
        nameof(Tooltip), 
        PrettyPrintName
    );
    
    protected override sealed void Register()
    {
        ModTypeLookup<ModPotentialModifier>.Register(this);
    }
}