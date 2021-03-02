using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Water.Stone
{

    public class WaterStone : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Water Stone");
            Tooltip.SetDefault("A small wet stone");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(silver: 75);
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.ElementalFragments.Water.Neromassinite>(), 1);
			recipe.AddIngredient(ItemID.CopperOre, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(5);
			recipe.AddRecipe();
        }
    }
}