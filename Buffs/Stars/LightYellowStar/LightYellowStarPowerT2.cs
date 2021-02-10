using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.LightYellowStar
{
    public class LightYellowStarPowerT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Light Yellow Star Power - Tier 2");
            Description.SetDefault("Lava immune = 10 Seconds");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.lavaMax = 600;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}