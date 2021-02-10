using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Stars.BlueStar
{
    public class BlueStarPower : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blue Star Power");
            Description.SetDefault("Magic Damage = +10%");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //player.buffTime[buffIndex] = 1;
            player.magicDamage += 0.1f;

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}