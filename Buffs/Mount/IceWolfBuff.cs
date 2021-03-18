using Terraria;
using Terraria.ModLoader;
using AwakeningMinerals.Mounts;

namespace AwakeningMinerals.Buffs.Mount
{
    public class IceWolfBuff : ModBuff
    {
            
        
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Ice Wolf");
            Description.SetDefault("Ice Wolf Mount Buff");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("IceWolf"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}