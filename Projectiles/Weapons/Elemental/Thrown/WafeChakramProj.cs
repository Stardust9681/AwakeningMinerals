using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Projectiles.Weapons.Elemental.Thrown
{
	public class WafeChakramProj : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(106);

			aiType = 106;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(mod.BuffType("AirDebuff"), 180);
			target.AddBuff(mod.BuffType("EarthDebuff"), 180);
			target.AddBuff(mod.BuffType("FireDebuff"), 180);
			target.AddBuff(mod.BuffType("WaterDebuff"), 180);
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("WafeChakramProj");

		}

	}
}
