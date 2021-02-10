using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.GreenStar
{
    public class GreenStarPower : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Green Star Power");
            Description.SetDefault("Ranged Damage = +10%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.rangedDamage += 0.1f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}