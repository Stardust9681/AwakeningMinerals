using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.TreasureBag.TsukiBoss.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class TsukiBossLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tsuki - Legs");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.LightPurple;
			item.vanity = true;
			item.expert = true;
		}
	}
}

