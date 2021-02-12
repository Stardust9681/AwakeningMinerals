using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Tiles;

namespace AwakeningMinerals.Items.SpecialItems
{
	public class AirStatueDownloads : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("1k downloads Air statue");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = TileType<Tiles.SpecialItems.AirStatueDownloadsTiles>();
			item.placeStyle = 0;
			item.rare = ItemRarityID.White;
		}
	}
}