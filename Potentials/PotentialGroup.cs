using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Occult.Items;
using Occult.Potentials.Modifiers;
using Occult.Potentials.Rarities;
using Terraria;
using Terraria.ModLoader.IO;

namespace Occult.Potentials;

public class PotentialGroup
{
    public ModPotentialRank Rank { get; set; }
    public ICollection<ModPotentialModifier> Modifiers { get; set; }

    public static PotentialGroup? Load(Item item, TagCompound tag)
    {
        try
        {
            return new PotentialGroup
            {
                Rank = Occult.Instance
                    .Find<ModPotentialRank>(tag.GetString(nameof(Rank))),
                Modifiers = tag
                    .GetList<string>(nameof(Modifiers))
                    .Select(Occult.Instance.Find<ModPotentialModifier>)
                    .Where(m => m.CanRoll(item))
                    .ToList()
            };
        }
        catch (Exception)
        {
            return null;
        }
    }

    public static void Save(Item item, PotentialGroup? potentials, TagCompound tag)
    {
        if (potentials != null)
        {
            tag.Add(nameof(Rank), potentials.Rank.Name);
            tag.Add(nameof(Modifiers), potentials.Modifiers
                .Where(m => m.CanRoll(item))
                .Select(m => m.Name)
                .ToList());
        }
    }

    public static PotentialGroup Roll(Item item, AbstractItemCube? cube = null)
    {
        var potentialsOld = item.GetGlobalItem<PotentialItem>().Potentials;
        var potentials = new PotentialGroup
        {
            Rank = potentialsOld?.Rank ?? Occult.Instance.Find<ModPotentialRank>(nameof(PotentialRankRare)),
            Modifiers = new List<ModPotentialModifier>()
        };
        var modifierCount = potentialsOld?.Modifiers.Count ?? 1;
        var modifiers = Occult.Instance
            .GetContent<ModPotentialModifier>()
            .Where(m => m.CanRoll(item))
            .ToImmutableArray();

        if (true)
            modifierCount = 3; // TODO

        for (var i = 0; i < modifierCount; i++)
        {
            var modifier = modifiers.MinBy(_ => Random.Shared.Next());

            if (modifier != null)
                potentials.Modifiers.Add(modifier);
        }

        return potentials;
    }
}
