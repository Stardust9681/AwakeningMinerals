using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items.AstralMoon;

namespace AwakeningMinerals.Items.Ancient
{
	public class AncientSeed : ModItem
	{
		public override void SetDefaults() {
			item.autoReuse = true;
			item.useTurn = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 15;
			item.useTime = 10;
			item.maxStack = 99;
			item.consumable = true;
			item.placeStyle = 0;
			item.width = 12;
			item.height = 14;
			item.value = 80;
			item.createTile = ModContent.TileType<Tiles.AncientHerb>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlinkrootSeeds, 1);
			recipe.AddIngredient(ItemID.DaybloomSeeds, 1);
			recipe.AddIngredient(ItemID.DeathweedSeeds, 1);
			recipe.AddIngredient(ItemID.FireblossomSeeds, 1);
			recipe.AddIngredient(ItemID.MoonglowSeeds, 1);
			recipe.AddIngredient(ItemID.ShiverthornSeeds, 1);
			recipe.AddIngredient(ItemID.WaterleafSeeds, 1);
			recipe.AddIngredient(ItemID.GrassSeeds, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}