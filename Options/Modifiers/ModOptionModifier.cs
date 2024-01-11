using Terraria.Localization;
using Terraria.ModLoader;

namespace Occult.Options.Modifiers;

public class ModOptionModifier : ModType, ILocalizedModType
{
    public string LocalizationCategory => "OptionModifiers";
    
    public virtual LocalizedText Tooltip => this.GetLocalization(
        nameof(Tooltip), 
        PrettyPrintName
    );
    
    protected override sealed void Register()
    {
        ModTypeLookup<ModOptionModifier>.Register(this);
    }
}