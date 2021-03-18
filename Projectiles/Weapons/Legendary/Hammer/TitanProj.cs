using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Dusts;

namespace AwakeningMinerals.Projectiles.Weapons.Legendary.Hammer
{
    public class TitanProj : ModProjectile
    {
		public override void SetDefaults()
		{
			projectile.width = 74;
			projectile.height = 72;

			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 20;
			projectile.light = 0.3f;
			projectile.extraUpdates = 1;
			aiType = ProjectileID.DemonScythe;
			projectile.tileCollide = false;
		}


	}
}
