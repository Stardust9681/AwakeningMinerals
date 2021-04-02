using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Armor.DeathBiome
{
    [AutoloadEquip(EquipType.Body)]
    public class DeathBiomeChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Death stone chestplate");
            Tooltip.SetDefault("Increase Minion damage +10%");

        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 24;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Purple;
            item.defense = 11; //How much armour it gives you
        }

        public override void UpdateEquip(Player player)
        {

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Death.Stone.DeathStone>(), 3);
            recipe.AddIngredient(ModContent.ItemType<Items.Death.DeathWood>(), 7);
            recipe.AddIngredient(ItemID.StoneBlock, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
