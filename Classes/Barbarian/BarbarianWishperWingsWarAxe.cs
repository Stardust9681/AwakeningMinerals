using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AwakeningMinerals.Classes.Barbarian
{
	public class BarbarianWishperWingsWarAxe : BarbarianDamageItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("WishperWings War Axe");
		}
		public override void SafeSetDefaults()
		{
			item.damage = 45;
			//item.ranged = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 20;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.melee = true;
			item.knockBack = 5;
			item.value = Terraria.Item.sellPrice(0, 0, 75, 0);
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("FireIceBolt");
			item.shootSpeed = 20f;
		}

		 public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 origVect = new Vector2(speedX, speedY);
			//generate the remaining projectiles

			Vector2 newVect = origVect.RotatedBy(System.Math.PI / (Main.rand.Next(72, 1800) / 10));
			Projectile.NewProjectile(position.X, position.Y, newVect.X, newVect.Y, mod.ProjectileType("FireBolt"), damage, knockBack, player.whoAmI, 0f, 0f);
			newVect = origVect.RotatedBy(System.Math.PI / (Main.rand.Next(72, 1800) / 10));
			Projectile.NewProjectile(position.X, position.Y, newVect.X * 1.5f, newVect.Y * 1.5f, mod.ProjectileType("IceBolt"), damage, knockBack, player.whoAmI, 0f, 0f);

			return false;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Fire.Stone.FireStone>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Items.Ice.Stone.IceStone>(), 1);
			recipe.AddIngredient(ItemID.HellstoneBrick, 20);
			recipe.AddIngredient(ItemID.IceBrick, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}