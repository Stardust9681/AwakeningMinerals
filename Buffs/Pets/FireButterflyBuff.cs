using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using AwakeningMinerals.Projectiles.Pets;
 
namespace AwakeningMinerals.Buffs.Pets
{
    public class FireButterflyBuff : ModBuff
    {

        public override void SetDefaults()
        {   
            DisplayName.SetDefault("Fire Butterfly");
            Description.SetDefault("Pet - Fire Butterfly.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
 
		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<AwakeningMineralsPlayer>().FireButterflyPet = true;

			bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<FireButterflyProj>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.Center, Vector2.Zero, ModContent.ProjectileType<FireButterflyProj>(), 0, 0f, player.whoAmI);
			}
		}
    }
}