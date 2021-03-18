using Terraria;
using Terraria.ModLoader;
using AwakeningMinerals.Mounts;

namespace AwakeningMinerals.Buffs.Mount
{
    public class FireWolfBuff : ModBuff
    {
            
        
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Fire Wolf");
            Description.SetDefault("Fire Wolf Mount Buff");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("FireWolf"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}