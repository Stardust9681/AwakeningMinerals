using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Weapons.TsukiBoss
{
    public class TsukiSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Sword");
            Tooltip.SetDefault("Drawed -Marshy");

        }

        public override void SetDefaults()
        {
            item.damage = 28;
            item.melee = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 30;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(silver: 75);
            item.rare = ItemRarityID.LightPurple;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.crit = 25;
        }
    }
}