using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Items.Ice;

namespace AwakeningMinerals.Items.Tools
{
	public class IceSolution : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cold Solution");
			Tooltip.SetDefault("Used by the Clentaminator"
				+ "\nSpreads the Ice Biome");
		}

		public override void SetDefaults() {
			item.shoot = ModContent.ProjectileType<Projectiles.Tool.IceSolutionProj>() - ProjectileID.PureSpray;
			item.ammo = AmmoID.Solution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 0, 25, 0);
			item.rare = ItemRarityID.Blue;
			item.maxStack = 999;
			item.consumable = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<IceSeed>(), 10);
			recipe.SetResult(this, 80);
			recipe.AddRecipe();
		}
	}
}
