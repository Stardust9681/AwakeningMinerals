using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Ancestral.Astral
{
	public class AstralNecklace : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Astral Necklace");
			Tooltip.SetDefault("A small necklace release a strong purple light\nMovement Speed = +20%\n Minion Slots : +3\n Minion Damage = +20%");
		}

		public override void SetDefaults() {
			item.width = 26;
			item.height = 26;
            item.value = Item.sellPrice(gold: 1);
			item.accessory = true;
			item.rare = ItemRarityID.LightPurple;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.maxMinions += 3;
			player.minionDamage += 0.2f;
			player.moveSpeed += 0.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Death.Stone.DeathStone>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Items.Death.Accessories.PurpleStar>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Items.Crystal>(), 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}