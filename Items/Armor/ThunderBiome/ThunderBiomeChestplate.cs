using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Armor.ThunderBiome
{
    [AutoloadEquip(EquipType.Body)]
    public class ThunderBiomeChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Thunder stone chestplate");
        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 24;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Yellow;
            item.defense = 9; //How much armour it gives you
        }

        public override void UpdateEquip(Player player)
        {

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Thunder.Stone.ThunderStone>(), 3);
            recipe.AddIngredient(ModContent.ItemType<Items.Thunder.ThunderWood>(), 7);
            recipe.AddIngredient(ItemID.StoneBlock, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
