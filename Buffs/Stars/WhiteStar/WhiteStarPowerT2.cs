using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.WhiteStar
{
    public class WhiteStarPowerT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("White Star Power - Tier 2");
            Description.SetDefault("Speed Movement = +15%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.moveSpeed += 0.15f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}