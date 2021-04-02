using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AwakeningMinerals.Buffs.Debuffs;

namespace AwakeningMinerals.Items.Armor.AstralMoonBiome
{
    [AutoloadEquip(EquipType.Body)]
    public class AstralMoonBiomeChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Astral Moon chestplate");
            Tooltip.SetDefault("Immune : Chilled\nMelee speed 10%\nTier 2");

        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 24;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.LightPurple;
            item.defense = 26; //How much armour it gives you
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.10f;
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
