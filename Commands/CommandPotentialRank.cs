using Occult.Potentials;
using Occult.Potentials.Rarities;
using Terraria.ModLoader;

namespace Occult.Commands;

public class CommandPotentialRank : ModCommand
{
    public override string Command => "potentialrank";
    public override CommandType Type => CommandType.World;
    
    public override void Action(CommandCaller caller, string input, string[] args)
    {
        var item = caller.Player.inventory[caller.Player.selectedItem];
        var potentials = item.GetGlobalItem<PotentialItem>().Potentials;
        var rank = Mod.Find<ModPotentialRank>(args[0]);

        if (potentials != null)
        {
            potentials.Rank = rank;
            caller.Reply($"Successfully set potential rank to {rank.DisplayName}");
        }
    }
}
