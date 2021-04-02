using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AwakeningMinerals.Buffs.Potions;

namespace AwakeningMinerals.Items.Armor.LightBiome
{
    [AutoloadEquip(EquipType.Head)]
    public class LightBiomeHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Light stone helmet");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Orange;
            item.defense = 18;

        }
        public override void UpdateEquip(Player player)
        {

        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("LightBiomeChestplate") && legs.type == mod.ItemType("LightBiomeLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Give Light Buff";

            player.AddBuff(ModContent.BuffType<LightBuff>(), 1);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Light.Stone.LightStone>(), 3);
            recipe.AddIngredient(ModContent.ItemType<Items.Light.LightWood>(), 7);
            recipe.AddIngredient(ItemID.StoneBlock, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}