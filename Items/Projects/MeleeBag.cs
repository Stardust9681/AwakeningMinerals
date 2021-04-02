using System;
using System.ComponentModel;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Projects
{
    public class MeleeBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Melee Bag");
            Tooltip.SetDefault("Content legendary melee weapons\nRight click to open");
        }

        public override void SetDefaults()
        {
            item.maxStack = 1;
            item.consumable = true;
            item.width = 30;
            item.height = 26;
            item.rare = -12;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            player.TryGettingDevArmor();
            int choice = Main.rand.Next(5);
            if (choice == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Weapons.Legendary.Swords.ElementalDragonTongue>());
            }
            if (choice == 1)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Weapons.Legendary.Swords.Krisi>());
            }
            if (choice == 2)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Weapons.Legendary.Swords.Timoria>());
            }
            if (choice == 3)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Weapons.Legendary.Spear.Valkyre>());
            }
            if (choice == 4)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.Weapons.Legendary.Hammer.Titan>());
            }
        }
    }
}