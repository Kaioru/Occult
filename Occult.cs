using Occult.Options.Rarities;
using Terraria.ModLoader;

namespace Occult
{
	public class Occult : Mod
	{
		public static Occult Instance { get; private set; }

		public override void Load()
		{
			Instance = this;
		}

		public override void PostSetupContent()
		{
			Instance.Find<ModOptionRarity>("PotentialRarityRare");
			Instance.Find<ModOptionRarity>("PotentialRarityEpic");
			Instance.Find<ModOptionRarity>("PotentialRarityUnique");
			
			base.PostSetupContent();
		}
	}
}