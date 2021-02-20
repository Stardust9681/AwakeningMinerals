using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.YellowStar
{
    public class YellowStarPowerT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Yellow Power - Tier 2");
            Description.SetDefault("Pick Speed = +15");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.pickSpeed = 0.15f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}