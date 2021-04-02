using Microsoft.Xna.Framework;
using AwakeningMinerals.Projectiles.Weapons.Legendary.Magic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AwakeningMinerals.Items.Projects;

namespace AwakeningMinerals.Items.Weapons.Legendary.Magic
{
	public class RedLantern : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Lantern");
			Tooltip.SetDefault("Shoots magical blood");
		}


		public override void SetDefaults()
		{
			item.damage = 15;
			item.magic = true;
			item.mana = 10;
			item.width = 44;
			item.height = 44;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			Item.staff[item.type] = true;
			item.noMelee = true;
			item.knockBack = 5;
            item.value = Item.sellPrice(gold: 50);
			item.rare = ItemRarityID.Expert;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<RedLanternProjectile>();
			item.shootSpeed = 2f;
			item.crit = 25;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int I = 0; I < 2; I++) {
				Projectile.NewProjectile(position.X - 8, position.Y + 4, speedX + ((float)Main.rand.Next(-250, 250) / 100), speedY + ((float)Main.rand.Next(-250, 250) / 100), type, damage, knockBack, player.whoAmI, 0f, 0f);
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