using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Ancestral.Cosmic
{
	public class CosmicNecklace : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Cosmic Necklace");
			Tooltip.SetDefault("A small necklace release a strong blue light\nMana Regen\nMana Cost = -10%\nMagic Damage = +20%");
		}

		public override void SetDefaults() {
			item.width = 26;
			item.height = 26;
            item.value = Item.sellPrice(gold: 1);
			item.accessory = true;
			item.rare = ItemRarityID.Blue;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.manaRegen = 40;
			player.magicDamage += 0.2f;
			player.manaCost -= 0.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Ice.Stone.IceStone>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Items.Ice.Accessories.BlueStar>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Items.Crystal>(), 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}