using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Classes.Barbarian
{
	public class BarbarianEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Barbarian Emblem");
			Tooltip.SetDefault("Barbarian Damage = +20%\n Barbarian Critic Chane = +5%");
		}

		public override void SetDefaults() {
			item.Size = new Vector2(22);
			item.rare = ItemRarityID.Red;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			var modPlayer = BarbarianDamagePlayer.ModPlayer(player);
			modPlayer.BarbarianDamageAdd += 0.2f;
			modPlayer.BarbarianCrit = 5;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Classes.EmptyDisk>(), 1);
			recipe.AddIngredient(ItemID.WarriorEmblem, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
