using Microsoft.Xna.Framework;
using AwakeningMinerals.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Projectiles.Weapons.Legendary.Sword.ElementalDragonTongue
{
	public class ElementalDragonTongueProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elemental DragonTongue Shard");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 16;

			projectile.aiStyle = 1;
			aiType = ProjectileID.Bullet;

			projectile.ranged = true;
			projectile.friendly = true;

			projectile.penetrate = 5;
			projectile.timeLeft = 600;
		}

		public override void AI()
		{
			for (int i = 0; i < 10; i++) {
				float x = projectile.Center.X - projectile.velocity.X / 10f * (float)i;
				float y = projectile.Center.Y - projectile.velocity.Y / 10f * (float)i;
				int num = Dust.NewDust(new Vector2(x, y), 26, 26, 61, 0f, 0f, 0, default(Color), 1f);
				Main.dust[num].alpha = projectile.alpha;
				Main.dust[num].position.X = x;
				Main.dust[num].position.Y = y;
				Main.dust[num].noGravity = true;
				Main.dust[num].velocity *= 0f;
			}
		}
	}
}
