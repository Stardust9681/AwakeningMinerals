using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Classes
{

    public class EmptyDisk : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Empty Disk");
            Tooltip.SetDefault("Use it for craft ur class");
        }

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 36;
            item.value = Item.sellPrice(copper: 20);
            item.rare = ItemRarityID.White;
            item.maxStack = 99;
        }
    		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
