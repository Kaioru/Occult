using System.Collections.Generic;
using Occult.Options.Modifiers;
using Occult.Options.Rarities;

namespace Occult.Options;

public class OptionPool
{
    public ModOptionRarity Rarity { get; }
    public ICollection<ModOptionModifier> Modifiers { get; }
}
