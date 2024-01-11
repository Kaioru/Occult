using System;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Occult.Potentials.Rarities;

public abstract class ModPotentialRarity : ModType, ILocalizedModType
{
    public string LocalizationCategory => "PotentialRarities";
    
    public virtual LocalizedText DisplayName => this.GetLocalization(
        nameof(DisplayName), 
        PrettyPrintName
    );
    
    public abstract Color Color { get; }
    public abstract Type? RarityUpgrade { get; }
    public abstract Type? RarityDowngrade { get; }
    
    protected override sealed void Register()
    {
        ModTypeLookup<ModPotentialRarity>.Register(this);
    }
}
