using AwakeningMinerals.Walls.ElementalBiomes;
using AwakeningMinerals.Items.Air.Stone;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Air
{
	public class AirStoneWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Air stone wall");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = WallType<Walls.ElementalBiomes.AirBiome.AirStoneWall>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<AirStone>(), 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}