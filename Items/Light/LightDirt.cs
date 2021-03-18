using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria;
using Terraria.ID;
using AwakeningMinerals.Tiles;
using AwakeningMinerals.Items.Ancient;

namespace AwakeningMinerals.Items.Light
{
	public class LightDirt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Light Dirt");
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
			item.createTile = TileType<Tiles.ElementalBiomes.LightGrassTile>();
		}

			public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<AncientSeed>(), 1);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}