using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace AwakeningMinerals.Classes.Barbarian
{
	public class BarbarianGoldenArtifact : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Barbarian goledn artifact");
			Tooltip.SetDefault("Barbarian Damage : =+20%");
		}

		public override void SetDefaults() {
			item.width = 26;
			item.height = 30;
			item.value = Terraria.Item.sellPrice(0, 0, 75, 0);
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) 
		{
			var modPlayer = BarbarianDamagePlayer.ModPlayer(player);
			modPlayer.BarbarianDamageAdd += 0.2f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WineGlass, 1);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}