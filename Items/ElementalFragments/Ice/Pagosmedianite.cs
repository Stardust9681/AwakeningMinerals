using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.ElementalFragments.Ice
{

    public class Pagosmedianite : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pagosmedianite");
            Tooltip.SetDefault("A strange medium blue stone");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 38;
            item.value = Item.sellPrice(silver: 40);
            item.rare = ItemRarityID.Blue;
            item.maxStack = 99;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), 50);
            recipe.AddIngredient(ItemID.StoneBlock, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}