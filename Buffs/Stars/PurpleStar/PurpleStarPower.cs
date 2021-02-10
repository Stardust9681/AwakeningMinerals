using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.PurpleStar
{
    public class PurpleStarPower : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Purple Star Power");
            Description.SetDefault("Minion Damage = +10%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.minionDamage = 0.1f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}