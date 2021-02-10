using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace AwakeningMinerals.Items
{

    public class IceHeartCrystal : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Heart Crystal");
            Tooltip.SetDefault("A cold heart crystal");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 11));
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.Cyan;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LifeCrystal, 1);
            recipe.AddIngredient(ItemID.IceBlock, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}