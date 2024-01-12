using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace Occult.UI;

[Autoload(Side = ModSide.Client)]
public class UISystem : ModSystem
{
    public UserInterface UI { get; private set; }
    
    public UIRerollState UIReroll { get; private set; }

    public override void Load()
    {
        UI = new UserInterface();
        UIReroll = new UIRerollState();
        
        UIReroll.Activate();
    }
    
    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        var mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
        
        if (mouseTextIndex != -1) {
            layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                "Occult: UI",
                delegate {
                    if (UI.CurrentState != null) {
                        UI.Draw(Main.spriteBatch, new GameTime());
                    }
                    return true;
                },
                InterfaceScaleType.UI
            ));
        }
    }
}
