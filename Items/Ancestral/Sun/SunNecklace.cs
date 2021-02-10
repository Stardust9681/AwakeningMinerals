using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Ancestral.Sun
{
	public class SunNecklace : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Sun Necklace");
			Tooltip.SetDefault("A small necklace release a strong yellow light\nMelee Speed = +20%\nMelee Damage = +20%\nArmor = 10");
		}

		public override void SetDefaults() {
			item.width = 26;
			item.height = 26;
            item.value = Item.sellPrice(gold: 1);
			item.accessory = true;
			item.rare = ItemRarityID.Yellow;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeSpeed += 0.2f;
			player.meleeDamage += 0.2f;
			player.statDefense += 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Fire.Stone.FireStone>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Items.Fire.Accessories.RedStar>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Items.Crystal>(), 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}