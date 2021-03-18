using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Buffs;

namespace AwakeningMinerals.Items.Pets
{
    public class MarshyButterfly : ModItem
    {
         public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			TooltipLine line = new TooltipLine(mod, "ItemName", "AM Contents");
			line.overrideColor = new Color(250, 200, 255);
			tooltips.Add(line);
			foreach (TooltipLine line2 in tooltips) {
				if (line2.mod == "Terraria" && line2.Name == "ItemName") {
					line2.overrideColor = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
					break;
				}
			}
		}
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Marshy Butterfly");
            Tooltip.SetDefault("Summon a pet - Marshy Butterfly.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 40;
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("MarshyButterflyProj");
            item.buffType = mod.BuffType("MarshyButterflyBuff");
            item.rare = ItemRarityID.Expert;
            item.shopCustomPrice = Item.sellPrice(platinum: 1);
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Pets.AirButterfly>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Pets.DeathButterfly>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Pets.EarthButterfly>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Pets.IceButterfly>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Pets.FireButterfly>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Pets.LightButterfly>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Pets.ThunderButterfly>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Pets.WaterButterfly>(), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}