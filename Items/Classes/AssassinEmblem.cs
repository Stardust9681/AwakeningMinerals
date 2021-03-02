using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Classes
{
	public class AssassinEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Assassin Emblem");
			Tooltip.SetDefault("Ranged Damage = +10%\nMovemenet Speed = +5%");
		}

		public override void SetDefaults() {
			item.width = 36;
			item.height = 36;
            item.value = Item.sellPrice(gold: 2);
			item.accessory = true;
			item.rare = ItemRarityID.Pink;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.rangedDamage += 0.10f;
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RangerEmblem, 1);
			recipe.AddIngredient(ItemID.ThrowingKnife, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}