using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Debuffs
{
	public class ThunderDebuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Thunder Debuff");
			Description.SetDefault("Silence");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.silence = true;

			//player.buffTime[buffIndex] = 120;
        }
	}
}
