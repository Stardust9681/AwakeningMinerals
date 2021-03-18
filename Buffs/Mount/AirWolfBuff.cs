using Terraria;
using Terraria.ModLoader;
using AwakeningMinerals.Mounts;

namespace AwakeningMinerals.Buffs.Mount
{
    public class AirWolfBuff : ModBuff
    {
            
        
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Air Wolf");
            Description.SetDefault("Air Wolf Mount Buff");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("AirWolf"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}