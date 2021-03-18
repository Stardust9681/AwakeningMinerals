using AwakeningMinerals.Walls.ElementalBiomes;
using AwakeningMinerals.Items.Ice.Stone;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Ice
{
	public class IceStoneWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice stone wall");
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
			item.createWall = WallType<Walls.ElementalBiomes.IceBiome.IceStoneWall>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<IceStone>(), 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}