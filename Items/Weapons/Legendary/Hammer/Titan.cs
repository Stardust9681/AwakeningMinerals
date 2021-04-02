using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Projectiles.Weapons.Legendary.Hammer;
using static Terraria.ModLoader.ModContent;

using AwakeningMinerals.Items.Projects;

namespace AwakeningMinerals.Items.Weapons.Legendary.Hammer
{
    public class Titan : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Titan");
            Tooltip.SetDefault("The legendary weapon of Earth");
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

			item.shoot = ModContent.ProjectileType<TitanProj>();
			item.shootSpeed = 3f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<MeleeBookProject>(), 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}