using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Weapons.Elemental.Thrown
{

	public class WafeChakram : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wafe Chakram");
			Tooltip.SetDefault("Punish your enemies with the 4 elements: Fire, Water, Air, Earth");
		}

		public override void SetDefaults()
		{

			item.damage = 45;
			item.thrown = true;
			item.width = 38;
			item.height = 38;
			item.useTime = 20;
			item.shootSpeed = 12f;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 3f;
			item.shoot = mod.ProjectileType("WafeChakramProj");
			item.value = 27600;
			item.rare = ItemRarityID.Red;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override bool CanUseItem(Player player)
		{
			for (int i = 0; i < 1000; ++i)
			{
				if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
				{
					return false;
				}
			}
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Water.Stone.WaterStone>(), 5);
			recipe.AddIngredient(ModContent.ItemType<Items.Air.Stone.AirStone>(), 5);
			recipe.AddIngredient(ModContent.ItemType<Items.Fire.Stone.FireStone>(), 5);
			recipe.AddIngredient(ModContent.ItemType<Items.Earth.Stone.EarthStone>(), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
