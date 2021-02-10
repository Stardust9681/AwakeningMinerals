using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.WhiteStar
{
    public class WhiteStarPower : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("White Star Power");
            Description.SetDefault("Speed Movement = +10%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.moveSpeed += 0.1f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}