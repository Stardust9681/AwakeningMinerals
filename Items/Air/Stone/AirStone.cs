using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Air.Stone
{

    public class AirStone : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Air Stone");
            Tooltip.SetDefault("A small windy stone");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(silver: 75);
            item.maxStack = 999;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.ElementalFragments.Air.Aeramassinite>(), 5);
			recipe.AddIngredient(ItemID.StoneBlock, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(5);
			recipe.AddRecipe();
        }
    }
}