using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AwakeningMinerals.Buffs.Potions;

namespace AwakeningMinerals.Items.Armor.AstralMoonBiome
{
    [AutoloadEquip(EquipType.Head)]
    public class AstralMoonBiomeHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Astral Moon stone helmet");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.LightPurple;
            item.defense = 25;
        }
        public override void UpdateEquip(Player player)
        {

        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("AstralMoonBiomeChestplate") && legs.type == mod.ItemType("AstralMoonBiomeLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Give all Elemental Buffs";

            player.AddBuff(ModContent.BuffType<AirBuff>(), 1);
            player.AddBuff(ModContent.BuffType<DeathBuff>(), 1);
            player.AddBuff(ModContent.BuffType<EarthBuff>(), 1);
            player.AddBuff(ModContent.BuffType<FireBuff>(), 1);
            player.AddBuff(ModContent.BuffType<IceBuff>(), 1);
            player.AddBuff(ModContent.BuffType<LightBuff>(), 1);
            player.AddBuff(ModContent.BuffType<ThunderBuff>(), 1);
            player.AddBuff(ModContent.BuffType<WaterBuff>(), 1);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.AstralMoon.MoonFragment>(), 3);
            recipe.AddIngredient(ModContent.ItemType<Items.AstralMoon.AstralMoonWood>(), 7);
            recipe.AddIngredient(ItemID.StoneBlock, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
