using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Ancestral.Moon
{
	public class MoonNecklace : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Moon Necklace");
			Tooltip.SetDefault("A small necklace release a strong white light\nGives the player a 25% chance to not consume ammo with any ranged weapon\nArrow Damage = +20%\nRanged Damage = +20%");
		}

		public override void SetDefaults() {
			item.width = 26;
			item.height = 26;
            item.value = Item.sellPrice(gold: 1);
			item.accessory = true;
			item.rare = ItemRarityID.White;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.arrowDamage += 0.2f;
			player.minionDamage += 0.2f;
			player.ammoCost75 = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Earth.Stone.EarthStone>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Items.Earth.Accessories.GreenStar>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Items.Crystal>(), 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}