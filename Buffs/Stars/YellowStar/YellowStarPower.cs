using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.YellowStar
{
    public class YellowStarPower : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Yellow Power");
            Description.SetDefault("Pick Speed = +10%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.pickSpeed = 0.1f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}