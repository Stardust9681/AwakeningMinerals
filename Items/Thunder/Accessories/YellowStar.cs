using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Thunder.Accessories
{
	[AutoloadEquip(EquipType.Back)]
	public class YellowStar : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Yellow Star");
            Tooltip.SetDefault("Summon a Yellow Gem to give you a little power\nPick Speed = +10%");
		}

		public override void SetDefaults() {
			item.width = 34;
			item.height = 38;
            item.value = Item.sellPrice(silver: 50);
			item.accessory = true;
			item.rare = ItemRarityID.Yellow;
		}

		public override void DrawArmorColor(Player drawPlayer, float shadow, ref Color color, ref int glowMask, ref Color glowMaskColor) {
			color = drawPlayer.GetImmuneAlphaPure(Color.White, shadow);
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(mod.BuffType("YellowStarPower"), 1, true);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Thunder.Stone.ThunderStone>(), 5);
			recipe.AddIngredient(ItemID.FallenStar, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}