using Terraria;
using Terraria.ModLoader;
using AwakeningMinerals.Mounts;

namespace AwakeningMinerals.Buffs.Mount
{
    public class WhiteWolfBuff : ModBuff
    {
            
        
        public override void SetDefaults()
        {
            DisplayName.SetDefault("White Wolf");
            Description.SetDefault("White Wolf Mount Buff");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("WhiteWolf"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}