using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Armor.EarthBiome
{
    [AutoloadEquip(EquipType.Body)]
    public class EarthBiomeChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Earth stone chestplate");
        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 24;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Lime;
            item.defense = 6; //How much armour it gives you
        }

        public override void UpdateEquip(Player player)
        {

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Earth.Stone.EarthStone>(), 3);
            recipe.AddIngredient(ModContent.ItemType<Items.Earth.EarthWood>(), 7);
            recipe.AddIngredient(ItemID.StoneBlock, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
