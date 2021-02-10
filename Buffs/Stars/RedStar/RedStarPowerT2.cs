using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.RedStar
{
    public class RedStarPowerT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Red Star Power - Tier 2");
            Description.SetDefault("Melee damage = +15%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.meleeDamage += 0.15f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}