using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace AwakeningMinerals.Items
{
    public class SummonTsuki : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tsuki Soul");
            Tooltip.SetDefault("Summon Tsuki, The moon light\nUse it during the night.");
        }
        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 34;
            item.maxStack = 999;
            item.value = 1000;
            item.rare = ItemRarityID.LightPurple;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return player.ZoneOverworldHeight && !Main.dayTime && !NPC.AnyNPCs(mod.NPCType("TsukiBoss"));
            {
                return !Main.dayTime && !NPC.AnyNPCs(mod.NPCType("TsukiBoss"));
            }
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("TsukiBoss"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);

            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.TsukiHeartCrystal>(), 1);
            recipe.AddIngredient(ItemID.StoneBlock, 5);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
