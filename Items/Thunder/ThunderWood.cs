using AwakeningMinerals.Tiles;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Thunder
{
	public class ThunderWood : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thunder wood");
		}
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = TileType<Tiles.ElementalBiomes.ThunderWoodTile>();
		}
	}
}