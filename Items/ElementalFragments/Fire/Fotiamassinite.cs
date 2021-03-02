using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.ElementalFragments.Fire
{

    public class Fotiamassinite : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fotiamassinite");
            Tooltip.SetDefault("A strange big red stone");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 54;
            item.value = Item.sellPrice(silver: 60);
            item.rare = ItemRarityID.Red;
            item.maxStack = 99;
        }
                public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.ElementalFragments.Fire.Fotiamedianite>(), 25);
            recipe.AddIngredient(ItemID.StoneBlock, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}