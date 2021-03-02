using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Items.ItemTek;

namespace AwakeningMinerals.Items.Tools.Tek
{
    public class PickAxeTronBlue : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pick-AxeTron21 - Blue");
            AwakeningMineralsGlowmask.AddGlowMask(item.type, "AwakeningMinerals/Items/Tools/Tek/PickAxeTronBlue_Glow");

        }
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 38;

            item.rare = ItemRarityID.Pink;
            item.value = Item.sellPrice(silver: 50);

            item.autoReuse = true;
            item.useTime = 16;
            item.useAnimation = 16;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 60;
            item.knockBack = 5.0f;
            item.crit = 5;

            item.axe = 35;
            item.pick = 175;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.ItemTek.Boss.MetalPlate>(), 20);
            recipe.AddIngredient(ModContent.ItemType<Items.ItemTek.Boss.MechanicalCore>(), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}