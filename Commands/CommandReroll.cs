using Occult.Items;
using Occult.Potentials;
using Terraria.ModLoader;

namespace Occult.Commands;

public class CommandReroll : ModCommand
{

    public override string Command => "reroll";
    public override CommandType Type => CommandType.World;
    
    public override void Action(CommandCaller caller, string input, string[] args)
    {
        var item = caller.Player.inventory[caller.Player.selectedItem];
        var cube = Mod.Find<ModItem>(nameof(ItemCubePrototype));

        try
        {
            cube = Mod.Find<ModItem>(args[0]);
        }
        catch
        {
        }
        
        if (cube is PotentialStrategy strategy)
        {
            item.GetGlobalItem<PotentialItem>().Potentials = PotentialGroup.Roll(item, strategy);
            caller.Reply($"Successfully rerolled potentials with {cube.DisplayName}");
        }
    }
}
