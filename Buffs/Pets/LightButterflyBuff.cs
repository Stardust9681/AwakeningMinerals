using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using AwakeningMinerals.Projectiles.Pets;
 
namespace AwakeningMinerals.Buffs.Pets
{
    public class LightButterflyBuff : ModBuff
    {

        public override void SetDefaults()
        {   
            DisplayName.SetDefault("Light Butterfly");
            Description.SetDefault("Pet - Light Butterfly.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
 
		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<AwakeningMineralsPlayer>().LightButterflyPet = true;

			bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<LightButterflyProj>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.Center, Vector2.Zero, ModContent.ProjectileType<LightButterflyProj>(), 0, 0f, player.whoAmI);
			}
		}
    }
}