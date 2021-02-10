using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.RedStar
{
    public class RedStarPower : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Red Star Power");
            Description.SetDefault("Melee damage = +10%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.meleeDamage += 0.1f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}