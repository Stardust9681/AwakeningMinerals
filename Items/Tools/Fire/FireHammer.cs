using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Tools.Fire
{
    public class FireHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Hammer");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.rare = ItemRarityID.Red;
            item.value = Item.sellPrice(silver: 50);

            item.autoReuse = true;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 30;
            item.knockBack = 6.0f;

            item.hammer = 65;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddIngredient(ItemID.Obsidian, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
