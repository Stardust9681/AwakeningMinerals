using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AwakeningMinerals.Buffs.Potions;

namespace AwakeningMinerals.Items.Armor.AirBiome
{
    [AutoloadEquip(EquipType.Body)]
    public class AirBiomeChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Air stone chestplate");
            Tooltip.SetDefault("Give Air Buff");
        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 24;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.White;
            item.defense = 15;
        }
        public override void UpdateEquip(Player player)
        {
            player.AddBuff(ModContent.BuffType<AirBuff>(), 1);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Air.Stone.AirStone>(), 3);
            recipe.AddIngredient(ModContent.ItemType<Items.Air.AirWood>(), 10);
            recipe.AddIngredient(ItemID.StoneBlock, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
