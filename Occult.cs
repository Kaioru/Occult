using Occult.Potentials.Rarities;
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
			Instance.Find<ModPotentialRarity>("PotentialRarityRare");
			Instance.Find<ModPotentialRarity>("PotentialRarityEpic");
			Instance.Find<ModPotentialRarity>("PotentialRarityUnique");
			
			base.PostSetupContent();
		}
	}
}