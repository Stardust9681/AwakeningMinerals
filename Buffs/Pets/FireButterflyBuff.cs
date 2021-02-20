using Terraria;
using Terraria.ModLoader;
 
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
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("FireButterflyProj")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("PetName"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}