using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Classes
{
	public class PaladinEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Paladin Emblem");
			Tooltip.SetDefault("Melee Damage = +10%\nLife = +250");
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
			player.meleeDamage += 0.10f;
			player.statLifeMax2 += 250;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WarriorEmblem, 1);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}