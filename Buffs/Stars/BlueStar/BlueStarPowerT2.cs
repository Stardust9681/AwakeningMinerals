using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.BlueStar
{
    public class BlueStarPowerT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blue Star Power - Tier 2");
            Description.SetDefault("Magic Damage = +15%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.magicDamage += 0.15f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}