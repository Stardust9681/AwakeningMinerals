using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Buffs;

namespace AwakeningMinerals.Items.Pets
{
    public class IceButterfly : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Butterfly");
            Tooltip.SetDefault("Summon a pet - Ice Butterfly.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 40;
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("IceButterflyProj");
            item.buffType = mod.BuffType("IceButterflyBuff");
            item.rare = ItemRarityID.Blue;
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Ice.Stone.IceStone>(), 5);
			recipe.AddIngredient(ItemID.JuliaButterfly, 1);
            recipe.AddIngredient(ItemID.MonarchButterfly, 1);
            recipe.AddIngredient(ItemID.PurpleEmperorButterfly, 1);
            recipe.AddIngredient(ItemID.RedAdmiralButterfly, 1);
            recipe.AddIngredient(ItemID.SulphurButterfly, 1);
            recipe.AddIngredient(ItemID.TreeNymphButterfly, 1);
            recipe.AddIngredient(ItemID.UlyssesButterfly, 1);
            recipe.AddIngredient(ItemID.ZebraSwallowtailButterfly, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}