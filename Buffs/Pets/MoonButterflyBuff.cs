using Terraria;
using Terraria.ModLoader;
 
namespace AwakeningMinerals.Buffs.Pets
{
    public class MoonButterflyBuff : ModBuff
    {

        public override void SetDefaults()
        {   
            DisplayName.SetDefault("Moon Butterfly");
            Description.SetDefault("Pet - Moon Butterfly.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
 
        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<AwakeningMineralsPlayer>().MoonButterflyPet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("MoonButterflyProj")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("PetName"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}