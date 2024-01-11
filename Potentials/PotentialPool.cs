using System.Collections.Generic;
using Occult.Potentials.Modifiers;
using Occult.Potentials.Rarities;

namespace Occult.Potentials;

public class PotentialPool
{
    public ModPotentialRank Rank { get; }
    public ICollection<ModPotentialModifier> Modifiers { get; }
}
