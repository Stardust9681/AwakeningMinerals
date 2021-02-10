using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.WaterGreenStar
{
    public class WaterGreenStarPowerT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Water Green Power - Tier 2");
            Description.SetDefault("Walk on any liquids\nNo fall damage");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.waterWalk = true;
            player.noFallDmg = true;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}