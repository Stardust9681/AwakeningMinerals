using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Weapons.Legendary.Swords
{
    public class Timoria : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Timoria");
            Tooltip.SetDefault("The legendary weapon of Punish");

        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.melee = true;
            item.width = 62;
            item.height = 62;
            item.useTime = 30;
            item.useAnimation = 35;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = Item.sellPrice(gold: 50);
            item.rare = ItemRarityID.Expert;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.crit = 25;
        }
    }
}