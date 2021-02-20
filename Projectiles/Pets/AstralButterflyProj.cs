using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AwakeningMinerals.Projectiles.Pets
{
    public class AstralButterflyProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AstralButterfly");
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 20;
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            AwakeningMineralsPlayer modPlayer = player.GetModPlayer<AwakeningMineralsPlayer>();
            if (player.dead)
            {
                modPlayer.AstralButterflyPet = false;
            }
            if (modPlayer.AstralButterflyPet)
            {
                projectile.timeLeft = 2;
            }
         }
    }
}