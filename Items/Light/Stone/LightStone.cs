using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Light.Stone
{

    public class LightStone : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Light Stone");
            Tooltip.SetDefault("A small holy stone");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.rare = ItemRarityID.Orange;
            item.value = Item.sellPrice(silver: 75);
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}