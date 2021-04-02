using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Debuffs
{
	public class IceDebuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Ice Debuff");
			Description.SetDefault("Frozen");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.frozen = true;

			//player.buffTime[buffIndex] = 120;
        }
	}
}
