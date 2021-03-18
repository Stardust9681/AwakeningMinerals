using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.AstralMoon
{

    public class MoonFragment : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Stone");
            Tooltip.SetDefault("A small strange stone");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.rare = ItemRarityID.LightPurple;
            item.value = Item.sellPrice(gold: 5);
            item.maxStack = 999;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Air.Stone.AirStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Death.Stone.DeathStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Earth.Stone.EarthStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Fire.Stone.FireStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Ice.Stone.IceStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Water.Stone.WaterStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Light.Stone.LightStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Thunder.Stone.ThunderStone>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}