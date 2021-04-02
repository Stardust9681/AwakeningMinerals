using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Debuffs
{
	// Ethereal Flames is an example of a buff that causes constant loss of life.
	// See ExamplePlayer.UpdateBadLifeRegen and ExampleGlobalNPC.UpdateLifeRegen for more information.
	public class AirDebuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Air Debuff");
			Description.SetDefault("Movement Speed -20%");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			longerExpertDebuff = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed -= 0.20f;

			//player.buffTime[buffIndex] = 120;
        }
	}
}
