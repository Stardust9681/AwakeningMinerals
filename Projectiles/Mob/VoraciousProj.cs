using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Projectiles.Mob
{
	public class VoraciousProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astral Arrow");
		}

		public override void SetDefaults()
		{
			projectile.width = 26;
			projectile.height = 32;
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.penetrate = 10;
			projectile.timeLeft = 1000;
			projectile.tileCollide = true;
			projectile.aiStyle = 1;
			aiType = ProjectileID.Bullet;
		}

		public override void Kill(int timeLeft)
		{
			Main.PlaySound(SoundID.Dig, (int)projectile.position.X, (int)projectile.position.Y);
			for (int i = 0; i < 20; i++) {
				Dust.NewDust(projectile.Center, projectile.width, projectile.height,
					0, 0, 1, 133);
			}

		}

	}
}