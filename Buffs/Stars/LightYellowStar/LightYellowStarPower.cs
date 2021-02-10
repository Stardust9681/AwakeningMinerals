using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.LightYellowStar
{
    public class LightYellowStarPower : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Light Yellow Star Power");
            Description.SetDefault("Lava immune = 5 Seconds");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.lavaMax = 300;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}