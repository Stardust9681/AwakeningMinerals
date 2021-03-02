using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Projects
{

    public class LegendaryChest : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Legendary Chest");
            Tooltip.SetDefault("Contents many legendary bags");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.value = Item.sellPrice(silver: 75);
            item.rare = ItemRarityID.Blue;
            item.maxStack = 999;
            item.shopCustomPrice = Item.sellPrice(platinum: 15);
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.TryGettingDevArmor();
            int choice = Main.rand.Next(6);
            if (choice == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Projects.SwordsBag.KrisiBag>());
            }
            if (choice == 1)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Projects.SwordsBag.TimoriaBag>());
            }
            if (choice == 2)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Projects.BowBag.ElementalistBag>());
            }
            if (choice == 3)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Projects.BowBag.FrostSpikeBag>());
            }
            if (choice == 4)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Projects.MagicBag.NatureStaffBag>());
            }
            if (choice == 5)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Projects.MagicBag.RedLanternBag>());
            }
        }
    }
}