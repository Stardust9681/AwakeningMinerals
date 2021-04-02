using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

using AwakeningMinerals.Items.Projects;

namespace AwakeningMinerals.Items.Weapons.Legendary.Bow
{

    public class FrostSpikes : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Spike");
            Tooltip.SetDefault("The legendary weapon of Ice");
        }

        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 70;
            item.rare = ItemRarityID.Expert;
            item.value = Item.sellPrice(gold: 75);

            item.useTime = 25;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;

            item.noMelee = true;
            item.ranged = true;
            item.damage = 40;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = 1;
            item.shootSpeed = 12f;
            item.crit = 25;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<RangedBookProject>(), 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
