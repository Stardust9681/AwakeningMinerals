using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace AwakeningMinerals.Classes.Barbarian
{
	public class BarbarianBeer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Barbarian beer");
			Tooltip.SetDefault("Barbarian Damage : =+10%\nAttack Speed =+10%\nSpeed Movemenet =+10%\nHP = +60");
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
			player.meleeSpeed += 0.1f;
			player.moveSpeed += 0.1f;
			player.statLifeMax2 += 60;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ale, 1);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddTile(TileID.Kegs);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}