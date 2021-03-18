using AwakeningMinerals.Walls.ElementalBiomes;
using AwakeningMinerals.Items.Fire.Stone;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Fire
{
	public class FireStoneWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fire stone wall");
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
			item.createWall = WallType<Walls.ElementalBiomes.FireBiome.FireStoneWall>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<FireStone>(), 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}