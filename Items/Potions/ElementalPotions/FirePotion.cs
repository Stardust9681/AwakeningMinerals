using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using AwakeningMinerals.Items.Ice;

namespace AwakeningMinerals.Items.Potions.ElementalPotions
{
    public class FirePotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Potion");
            Tooltip.SetDefault("Give Warmth buff");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 34;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Red;
            item.value = Item.sellPrice(silver: 25);
            item.buffType = BuffType<Buffs.Potions.FireBuff>(); //Specify an existing buff to be applied when used.
            item.buffTime = 2880; //The amount of time the buff declared in item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Fire.Stone.FireStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Plants.FireFlower>(), 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
