using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.GreenStar
{
    public class GreenStarPowerT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Green Star Power - Tier 2");
            Description.SetDefault("Ranged Damage = +15%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.rangedDamage += 0.15f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}