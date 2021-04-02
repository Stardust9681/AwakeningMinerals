using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using AwakeningMinerals.Items.Projects;

namespace AwakeningMinerals.Items.Weapons.Legendary.Swords
{
    public class Krisi : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Krisi");
            Tooltip.SetDefault("The legendary weapon of Judgment");

        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.melee = true;
            item.width = 66;
            item.height = 68;
            item.useTime = 30;
            item.useAnimation = 40;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = Item.sellPrice(gold: 50);
            item.rare = ItemRarityID.Expert;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.crit = 25;
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