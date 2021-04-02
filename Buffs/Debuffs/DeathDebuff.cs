using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Debuffs
{
	public class DeathDebuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Death Debuff");
			Description.SetDefault("Confused");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.confused = true;

			//player.buffTime[buffIndex] = 120;
        }
	}
}
