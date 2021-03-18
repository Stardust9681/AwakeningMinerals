using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Weapons.Legendary.Spear
{
    public class Valkyre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Valkyre");
            Tooltip.SetDefault("The legendary weapon of Wind");
        }

        public override void SetDefaults()
        {
            item.damage = 35;
            item.melee = true;
            item.width = 122;
            item.height = 124;
            item.maxStack = 1;
            item.useTime = 22;
            item.useAnimation = 32;
            item.knockBack = 4f;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = false;
            item.useStyle = 5;
            item.value = Item.sellPrice(gold: 50);
            item.rare = ItemRarityID.Expert;
            item.shoot = mod.ProjectileType("ValkyreProj");
            item.shootSpeed = 5f;
            item.crit = 25;
        }
    }
}