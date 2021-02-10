using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.WaterGreenStar
{
    public class WaterGreenStarPower : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Water Green Power");
            Description.SetDefault("Walk on any liquids");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.waterWalk = true;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}