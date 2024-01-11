using System;
using System.Collections.Generic;
using System.Linq;
using Occult.Potentials.Modifiers;
using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Occult.Potentials;

public class PotentialPool
{
    public ModPotentialRank Rank { get; set; }
    public ICollection<ModPotentialModifier> Modifiers { get; set; }
    
    public static PotentialPool? Load(Mod mod, TagCompound tag)
    {
        try
        {
            return new PotentialPool
            {
                Rank = mod
                    .Find<ModPotentialRank>(tag.GetString(nameof(Rank))),
                Modifiers = tag
                    .GetList<string>(nameof(Modifiers))
                    .Select(mod.Find<ModPotentialModifier>)
                    .ToList()
            };
        }
        catch (Exception)
        {
            return null;
        }
    }
    
    public static void Save(PotentialPool? potentials, TagCompound tag)
    {
        if (potentials != null)
        {
            tag.Add(nameof(Rank), potentials.Rank.Name);
            tag.Add(nameof(Modifiers), potentials.Modifiers.Select(m => m.Name).ToList());
        }
    }
}
