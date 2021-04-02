﻿using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AwakeningMinerals.Classes.Barbarian
{
	public class BarbarianLeadWarAxe : BarbarianDamageItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lead War Axe");
		}
		public override void SafeSetDefaults()
		{
			item.damage = 8;
			//item.ranged = true;
			item.width = 62;
			item.height = 30;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.melee = true;
			item.knockBack = 5;
			item.value = Terraria.Item.sellPrice(0, 0, 75, 0);
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 9);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}