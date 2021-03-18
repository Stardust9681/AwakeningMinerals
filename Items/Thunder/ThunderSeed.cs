using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Items.Thunder.Stone;

namespace AwakeningMinerals.Items.Thunder
{
	public class ThunderSeed : ModItem
	{
		public override void SetDefaults() {
			item.width = 14;
            item.height = 12;
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.Lime;
            item.maxStack = 99;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlinkrootSeeds, 1);
			recipe.AddIngredient(ItemID.DaybloomSeeds, 1);
			recipe.AddIngredient(ItemID.DeathweedSeeds, 1);
			recipe.AddIngredient(ItemID.FireblossomSeeds, 1);
			recipe.AddIngredient(ItemID.MoonglowSeeds, 1);
			recipe.AddIngredient(ItemID.ShiverthornSeeds, 1);
			recipe.AddIngredient(ItemID.WaterleafSeeds, 1);
			recipe.AddIngredient(ItemID.GrassSeeds, 1);
			recipe.AddIngredient(ModContent.ItemType<ThunderStone>(), 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}