using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Tiles;
using Terraria;

namespace AwakeningMinerals.Items.Minerals.Ores
{
	public class XonyOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Xony Ore");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 57;
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.Minerals.Ores.XonyOreTile>();
			item.width = 12;
			item.height = 12;
            item.value = Item.sellPrice(silver: 75);
			item.rare = ItemRarityID.Blue;
		}
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Ice.Stone.IceStone>(), 1);
			recipe.AddIngredient(ItemID.CopperOre, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(5);
			recipe.AddRecipe();
			new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Fire.Stone.FireStone>(), 1);
			recipe.AddIngredient(ItemID.TinOre, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(5);
			recipe.AddRecipe();
        }
	}
}
