using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AwakeningMinerals.Buffs.Potions;

namespace AwakeningMinerals.Items.Armor.ThunderBiome
{
    [AutoloadEquip(EquipType.Head)]
    public class ThunderBiomeHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thunder stone helmet");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Yellow;
            item.defense = 8;

        }
        public override void UpdateEquip(Player player)
        {

        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ThunderBiomeChestplate") && legs.type == mod.ItemType("ThunderBiomeLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Give Thunder Buff";

            player.AddBuff(ModContent.BuffType<ThunderBuff>(), 1);
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