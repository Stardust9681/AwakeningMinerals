using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Dusts;

namespace AwakeningMinerals.Projectiles.Weapons.Legendary.Magic
{
    public class RedLanternProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 12;
            projectile.height = 18;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 400;
            projectile.light = 0.10f;
            aiType = 1;
        }

        public override void AI()
        {
            if (Main.rand.NextBool(3))
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.height, projectile.width, ModContent.DustType<RedLanternDust>(),
                    projectile.velocity.X * .2f, projectile.velocity.Y * .2f, 150, Scale: 1.2f);
                dust.velocity += projectile.velocity * 0.3f;
                dust.velocity *= 0.2f;
            }

            if (Main.rand.NextBool(4))
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.height, projectile.width, ModContent.DustType<RedLanternDust>(),
                    0, 0, 150, Scale: 0.3f);
                dust.velocity += projectile.velocity * 0.5f;
                dust.velocity *= 0.5f;
            }
        }
        public override void OnHitNPC(NPC player, int damage, float knockback, bool crit)
        {
            player.lifeRegen += 10;
        }
    }
}