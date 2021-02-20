using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Tools.Ice
{
    public class IceAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Axe");

        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 28;

            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(silver: 50);

            item.autoReuse = true;
            item.useTime = 27;
            item.useAnimation = 35;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 40;
            item.knockBack = 5.0f;

            item.axe = 14;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddIngredient(ItemID.IceBlock, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}