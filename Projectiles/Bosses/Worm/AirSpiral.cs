using AwakeningMinerals.Buffs.Debuffs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Projectiles.Bosses.Worm
{
	public class AirSpiral : ModProjectile
	{
		public float warningTime;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TsukiSpiral");

		}
		public override void SetDefaults()
		{
            projectile.damage = 15;
            projectile.width = 33;
            projectile.height = 31;
            projectile.aiStyle = -1;
            projectile.hostile = true;
            projectile.friendly = false;
            projectile.melee = true;
            projectile.penetrate = 3;
			aiType = 229;
		}
		public override void OnHitPlayer(Player player, int damage, bool crit)
		{
			if (Main.rand.NextBool(3))
			{
				player.AddBuff(mod.BuffType("MoonDebuff"), 60, true);
			}
		}
	}
}