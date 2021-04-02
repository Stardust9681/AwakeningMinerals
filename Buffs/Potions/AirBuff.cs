using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Potions
{
	// Ethereal Flames is an example of a buff that causes constant loss of life.
	// See ExamplePlayer.UpdateBadLifeRegen and ExampleGlobalNPC.UpdateLifeRegen for more information.
	public class AirBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Air Buff");
			Description.SetDefault("Movement Speed +20%");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.20f;

			//player.buffTime[buffIndex] = 120;
        }
	}
}
