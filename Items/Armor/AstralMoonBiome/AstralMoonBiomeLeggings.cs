using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Armor.AstralMoonBiome
{
    [AutoloadEquip(EquipType.Legs)]
    public class AstralMoonBiomeLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice crystal leggings");
            Tooltip.SetDefault("Immune : Frost Burn\nMove Speed 15%\nTier 2");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 18;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.LightPurple;
            item.defense = 25;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.15f;
            player.buffImmune[BuffID.Frostburn] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.AstralMoon.MoonFragment>(), 3);
            recipe.AddIngredient(ModContent.ItemType<Items.AstralMoon.AstralMoonWood>(), 5);
            recipe.AddIngredient(ItemID.StoneBlock, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}