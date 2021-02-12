using System;
using System.ComponentModel;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.SpecialItems
{
    public class GiftCapusle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gift capsule");
            Tooltip.SetDefault("Thanks for playing this mod\nRight click to open");
        }

        public override void SetDefaults()
        {
            item.maxStack = 1;
            item.consumable = true;
            item.width = 34;
            item.height = 48;
            item.rare = -12;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            int choice = Main.rand.Next(3);
            if (choice == 0)
            {
                player.QuickSpawnItem(mod.ItemType("Crystal"), Main.rand.Next(1, 5));
            }
            if (choice == 1)
            {
                player.QuickSpawnItem(mod.ItemType("SummonTsuki"));
            }
            if (choice == 2)
            {
                player.QuickSpawnItem(mod.ItemType("IceStatueDownloads"));
            }
            if (choice == 3)
            {
                player.QuickSpawnItem(mod.ItemType("AirStatueDownloads"));
            }
            if (choice == 4)
            {
                player.QuickSpawnItem(mod.ItemType("DeathStatueDownloads"));
            }
            if (choice == 5)
            {
                player.QuickSpawnItem(mod.ItemType("EarthStatueDownloads"));
            }
            if (choice == 6)
            {
                player.QuickSpawnItem(mod.ItemType("LightStatueDownloads"));
            }
            if (choice == 7)
            {
                player.QuickSpawnItem(mod.ItemType("ThunderStatueDownloads"));
            }
            if (choice == 8)
            {
                player.QuickSpawnItem(mod.ItemType("MoonStatueDownloads"));
            }
            if (choice == 9)
            {
                player.QuickSpawnItem(mod.ItemType("FireStatueDownloads"));
            }
            if (choice == 10)
            {
                player.QuickSpawnItem(mod.ItemType("waterStatueDownloads"));
            }
        }
        		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronOre, 10);
			recipe.AddIngredient(ItemID.GoldCoin, 5);
            recipe.AddIngredient(ItemID.Glass, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadOre, 10);
			recipe.AddIngredient(ItemID.GoldCoin, 5);
            recipe.AddIngredient(ItemID.Glass, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}