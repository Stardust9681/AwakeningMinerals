using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AwakeningMinerals.Buffs.Potions;

namespace AwakeningMinerals.Items.Armor.WaterBiome
{
    [AutoloadEquip(EquipType.Head)]
    public class WaterBiomeHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Water stone helmet");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Green;
            item.defense = 12;

        }
        public override void UpdateEquip(Player player)
        {

        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("WaterBiomeChestplate") && legs.type == mod.ItemType("WaterBiomeLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Give Water Buff";

            player.AddBuff(ModContent.BuffType<WaterBuff>(), 1);
        }

       public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Water.Stone.WaterStone>(), 3);
            recipe.AddIngredient(ModContent.ItemType<Items.Water.WaterWood>(), 7);
            recipe.AddIngredient(ItemID.StoneBlock, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}