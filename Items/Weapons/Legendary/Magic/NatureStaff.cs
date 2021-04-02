using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Projectiles.Weapons.Legendary.Magic;

using AwakeningMinerals.Items.Projects;

namespace AwakeningMinerals.Items.Weapons.Legendary.Magic
{
	public class NatureStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nature staff");
			Tooltip.SetDefault("Shoot randomic magic spikes");

		}		public override void SetDefaults()
		{

			item.mana = 15;
			item.UseSound = SoundID.Item8;
			item.useStyle = 5;
			item.damage = 10;
			item.useTime = 40;
			item.useAnimation = 40;
			item.width = 36;
			item.height = 40;

			item.knockBack = 4;
			Item.staff[item.type] = true;
			item.magic = true;
			item.autoReuse = true;
            item.value = Item.sellPrice(gold: 50);
			item.rare = ItemRarityID.Expert;
			item.noMelee = true;
			item.crit = 25;

			item.shoot = ModContent.ProjectileType<PinkSpike>();
			item.shootSpeed = 2f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int I = 0; I < 8; I++) {
				Projectile.NewProjectile(position.X - 8, position.Y + 8, speedX + ((float)Main.rand.Next(-300, 300) / 30), speedY + ((float)Main.rand.Next(-300, 300) / 30), type, damage, knockBack, player.whoAmI, 0f, 0f);
				if (Main.rand.Next(6) == 0) {
					Projectile.NewProjectile(position.X - 8, position.Y + 8, speedX + ((float)Main.rand.Next(-300, 300) / 30), speedY + ((float)Main.rand.Next(-300, 300) / 30), type, damage, knockBack, player.whoAmI, 0f, 0f);
				}
			}
			return false;
		}
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<MagicBookProject>(), 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

	}
}
