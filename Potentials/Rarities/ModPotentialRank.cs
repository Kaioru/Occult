using System;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Occult.Potentials.Rarities;

public abstract class ModPotentialRank : ModType, ILocalizedModType
{
    public string LocalizationCategory => "PotentialRanks";
    
    public virtual LocalizedText DisplayName => this.GetLocalization(
        nameof(DisplayName), 
        PrettyPrintName
    );
    
    public abstract Color Color { get; }
    public abstract Type? UpgradeRank { get; }
    public abstract Type? DowngradeRank { get; }
    
    public abstract float Multiplier { get; }
    
    protected override sealed void Register()
    {
        ModTypeLookup<ModPotentialRank>.Register(this);
    }
}
