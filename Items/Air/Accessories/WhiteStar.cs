using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Air.Accessories
{
	[AutoloadEquip(EquipType.Back)]
	public class WhiteStar : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("White Star");
			Tooltip.SetDefault("Summon a White Gem to give you a little power\nMovement Speed = +10%");
		}

		public override void SetDefaults() {
			item.width = 34;
			item.height = 38;
            item.value = Item.sellPrice(silver: 50);
			item.accessory = true;
			item.rare = ItemRarityID.White;
		}

		public override void DrawArmorColor(Player drawPlayer, float shadow, ref Color color, ref int glowMask, ref Color glowMaskColor) {
			color = drawPlayer.GetImmuneAlphaPure(Color.White, shadow);
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(mod.BuffType("WhiteStarPower"), 1, true);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Air.Stone.AirStone>(), 5);
			recipe.AddIngredient(ItemID.FallenStar, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}