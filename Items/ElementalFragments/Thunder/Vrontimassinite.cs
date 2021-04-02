using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.ElementalFragments.Thunder
{

    public class Vrontimassinite : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vrontimassinite");
            Tooltip.SetDefault("A strange big yellow stone");
        }

        public override void SetDefaults()
        {
            item.width = 50;
            item.height = 50;
            item.value = Item.sellPrice(silver: 60);
            item.rare = ItemRarityID.Yellow;
            item.maxStack = 99;
        }
                public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontimedianite>(), 25);
            recipe.AddIngredient(ItemID.StoneBlock, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}