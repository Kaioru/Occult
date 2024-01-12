using System;
using System.Collections.Immutable;
using System.Linq;
using Occult.Potentials;
using Occult.Potentials.Modifiers;
using Terraria.ModLoader;

namespace Occult.Commands;

public class CommandPotentialModifier : ModCommand
{
    public override string Command => "potentialmodifier";
    public override CommandType Type => CommandType.World;
    
    public override void Action(CommandCaller caller, string input, string[] args)
    {
        var item = caller.Player.inventory[caller.Player.selectedItem];
        var potentials = item.GetGlobalItem<PotentialItem>().Potentials;
        var index = Convert.ToInt32(args[0]);
        var modifier =
            args.Length > 1
                ? Mod.Find<ModPotentialModifier>(args[1])
                : null;

        if (potentials != null)
        {
            foreach (var (i, target) in potentials.Modifiers
                         .Select((e, i) => (i, e))
                         .ToImmutableList())
            {
                if (i != index) continue;
                potentials.Modifiers.Remove(target);
                if (modifier != null)
                    potentials.Modifiers.Add(modifier);
                break;
            }

            caller.Reply($"Successfully set modifier {index} to {modifier}");
        }
    }
}
