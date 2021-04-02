using Microsoft.Xna.Framework;
using AwakeningMinerals.Dusts;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Projectiles.Classes.Barbarian
{
	public class IceBolt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Bolt Proj");
		}

		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 50;

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
            }
            if (Main.rand.NextBool(3))
            {
            	Dust dust = Dust.NewDustDirect(projectile.position, projectile.height, projectile.width, ModContent.DustType<IceWeaponDust>(),
                projectile.velocity.X * .2f, projectile.velocity.Y * .2f, 150, Scale: 1.2f);
                dust.velocity += projectile.velocity * 0.3f;
                dust.velocity *= 0.2f;
            }
		}
	}
}
