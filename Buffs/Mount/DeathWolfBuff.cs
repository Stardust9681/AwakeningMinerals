using Terraria;
using Terraria.ModLoader;
using AwakeningMinerals.Mounts;

namespace AwakeningMinerals.Buffs.Mount
{
    public class DeathWolfBuff : ModBuff
    {
            
        
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Death Wolf");
            Description.SetDefault("Death Wolf Mount Buff");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("DeathWolf"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}