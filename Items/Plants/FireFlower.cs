using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AwakeningMinerals.Items.Ancient;

namespace AwakeningMinerals.Items.Plants
{

    public class FireFlower : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Flower");
            Tooltip.SetDefault("This flower have the infernal power");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = Item.sellPrice(silver: 75);
            item.rare = ItemRarityID.Purple;
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Fire.Stone.FireStone>(), 1);
    		recipe.AddIngredient(ModContent.ItemType<Items.Ancient.AncientFlower>(), 1);
			recipe.AddTile(TileID.ClayPot);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}