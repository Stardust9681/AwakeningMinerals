using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Items.Light;

namespace AwakeningMinerals.Items.Tools
{
	public class LightSolution : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Holy Solution");
			Tooltip.SetDefault("Used by the Clentaminator"
				+ "\nSpreads the Light Biome");
		}

		public override void SetDefaults() {
			item.shoot = ModContent.ProjectileType<Projectiles.Tool.LightSolutionProj>() - ProjectileID.PureSpray;
			item.ammo = AmmoID.Solution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 0, 25, 0);
			item.rare = ItemRarityID.Orange;
			item.maxStack = 999;
			item.consumable = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LightSeed>(), 10);
			recipe.SetResult(this, 80);
			recipe.AddRecipe();
		}
	}
}
