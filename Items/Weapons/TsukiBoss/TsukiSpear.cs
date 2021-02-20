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
    public class TsukiSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Spear");
        }

        public override void SetDefaults()
        {
            item.damage = 28;
            item.melee = true;
            item.width = 62;
            item.height = 62;
            item.maxStack = 1;
            item.useTime = 25;
            item.useAnimation = 30;
            item.knockBack = 4f;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = false;
            item.useStyle = 5;
            item.value = Item.sellPrice(silver: 75);
            item.rare = ItemRarityID.LightPurple;
            item.shoot = mod.ProjectileType("TsukiSpearProj");
            item.shootSpeed = 5f;
            item.crit = 25;
        }
    }
}