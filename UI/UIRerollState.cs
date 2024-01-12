using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Occult.UI;

public class UIRerollState : UIState
{
    public override void OnInitialize()
    {
        var panel = new UIPanel();
        
        panel.SetPadding(0);
        panel.Left.Set(20, 0);
        panel.Top.Set(275, 0);
        panel.Height.Set(100, 0);
        panel.Width.Set(400, 0);

        Append(panel);
    }
}
