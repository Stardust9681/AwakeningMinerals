using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.PurpleStar
{
    public class PurpleStarPowerT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Purple Star Power - Tier 2");
            Description.SetDefault("Minion Damage = +15%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.minionDamage = 0.15f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}