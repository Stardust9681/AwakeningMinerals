using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Debuffs
{
	public class LightDebuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Light Debuff");
			Description.SetDefault("Blackout");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.blackout = true;

			player.buffTime[buffIndex] = 120;
        }
	}
}
