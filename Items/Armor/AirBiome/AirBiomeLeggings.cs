using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Armor.AirBiome
{
    [AutoloadEquip(EquipType.Legs)]
    public class AirBiomeLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Air stone leggings");
            Tooltip.SetDefault("Give Movement speed = +5%");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 18;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.White;
            item.defense = 14;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed = 0.05f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Air.Stone.AirStone>(), 3);
            recipe.AddIngredient(ModContent.ItemType<Items.Air.AirWood>(), 5);
            recipe.AddIngredient(ItemID.StoneBlock, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
