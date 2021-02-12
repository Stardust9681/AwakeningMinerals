using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Fire.Accessories
{
	[AutoloadEquip(EquipType.Back)]
	public class RedStar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Red Star");
            Tooltip.SetDefault("Summon a Red Gem to give you a little power\nMelee Damage = +10%");
		}

		public override void SetDefaults() {
			item.width = 34;
			item.height = 38;
            item.value = Item.sellPrice(silver: 50);
			item.accessory = true;
			item.rare = ItemRarityID.Red;
		}

		public override void DrawArmorColor(Player drawPlayer, float shadow, ref Color color, ref int glowMask, ref Color glowMaskColor) {
			color = drawPlayer.GetImmuneAlphaPure(Color.White, shadow);
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(mod.BuffType("RedStarPower"), 1, true);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Fire.Stone.FireStone>(), 5);
			recipe.AddIngredient(ItemID.FallenStar, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}