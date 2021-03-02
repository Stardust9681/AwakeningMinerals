using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Classes
{
	public class DruidEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Druid Emblem");
			Tooltip.SetDefault("Minion Damage = +10%\nMinions = +2");
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
			player.minionDamage += 0.10f;
			player.slotsMinions += 2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SummonerEmblem, 1);
			recipe.AddIngredient(ItemID.TikiMask, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}