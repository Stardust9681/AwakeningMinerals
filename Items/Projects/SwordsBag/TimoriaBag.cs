using System;
using System.ComponentModel;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.Projects.SwordsBag
{
    public class TimoriaBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Timoria Bag");
            Tooltip.SetDefault("Content Timoria\nRight click to open");
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
                Item.NewItem(player.getRect(), ModContent.ItemType<Items.Weapons.Legendary.Swords.Timoria>(), 1);
        }
    }
}