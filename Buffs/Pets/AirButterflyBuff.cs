using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using AwakeningMinerals.Projectiles.Pets;
 
namespace AwakeningMinerals.Buffs.Pets
{
    public class AirButterflyBuff : ModBuff
    {

        public override void SetDefaults()
        {   
            DisplayName.SetDefault("Air Butterfly");
            Description.SetDefault("Pet - Air Butterfly.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
 
		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<AwakeningMineralsPlayer>().AirButterflyPet = true;

			bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<AirButterflyProj>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.Center, Vector2.Zero, ModContent.ProjectileType<AirButterflyProj>(), 0, 0f, player.whoAmI);
			}
		}
    }
}