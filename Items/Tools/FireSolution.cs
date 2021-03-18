using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Items.Fire;

namespace AwakeningMinerals.Items.Tools
{
	public class FireSolution : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Monochromatic Solution");
			Tooltip.SetDefault("Used by the Clentaminator"
				+ "\nSpreads the Fire Biome");
		}

		public override void SetDefaults() {
			item.shoot = ModContent.ProjectileType<Projectiles.Tool.FireSolutionProj>() - ProjectileID.PureSpray;
			item.ammo = AmmoID.Solution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 0, 25, 0);
			item.rare = ItemRarityID.Red;
			item.maxStack = 999;
			item.consumable = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<FireSeed>(), 10);
			recipe.SetResult(this, 999);
			recipe.AddRecipe();
		}
	}
}
