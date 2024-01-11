using Terraria.ModLoader;

namespace Occult
{
	public class Occult : Mod
	{
		public static Occult Instance { get; private set; }

		public override void Load()
			=> Instance = this;
	}
}