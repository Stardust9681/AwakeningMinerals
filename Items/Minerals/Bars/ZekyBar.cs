using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Tiles;
using Terraria;

namespace AwakeningMinerals.Items.Minerals.Bars
{
	public class ZekyBar : ModItem
	{ 
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zeky Bar");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 59;
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = TileType<Tiles.Minerals.Bars.ZekyBarTile>();
			item.placeStyle = 0;
            item.value = Item.sellPrice(silver: 75);
			item.rare = ItemRarityID.Green;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Minerals.Ores.ZekyOre>(), 2);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(5);
			recipe.AddRecipe();
		}
	}
}