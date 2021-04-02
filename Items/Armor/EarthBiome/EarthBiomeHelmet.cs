using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AwakeningMinerals.Buffs.Potions;

namespace AwakeningMinerals.Items.Armor.EarthBiome
{
    [AutoloadEquip(EquipType.Head)]
    public class EarthBiomeHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Earth stone helmet");

        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Lime;
            item.defense = 4;

        }
        public override void UpdateEquip(Player player)
        {

        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("EarthBiomeChestplate") && legs.type == mod.ItemType("EarthBiomeLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Give Earth Buff";

            player.AddBuff(ModContent.BuffType<EarthBuff>(), 1);
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