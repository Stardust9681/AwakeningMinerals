using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace AwakeningMinerals.Classes.Barbarian
{
	[AutoloadEquip(EquipType.Shield)]
	public class BarbarianShield : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Barbarian Wood Shield");
			Tooltip.SetDefault("Defense = +8\n Speed Movemenet =-10%");
		}

		public override void SetDefaults() {
			item.width = 40;
			item.height = 40;
			item.value = Terraria.Item.sellPrice(0, 0, 75, 0);
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) 
		{
			player.statDefense += 8;
			player.moveSpeed -= 0.10f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}