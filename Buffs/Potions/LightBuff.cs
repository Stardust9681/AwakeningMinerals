using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Potions
{
	// Ethereal Flames is an example of a buff that causes constant loss of life.
	// See ExamplePlayer.UpdateBadLifeRegen and ExampleGlobalNPC.UpdateLifeRegen for more information.
	public class LightBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Light Buff");
			Description.SetDefault("Night vision, Spelunker");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
        player.nightVision = true;
		player.findTreasure = true;

			//player.buffTime[buffIndex] = 120;
        }
	}
}
