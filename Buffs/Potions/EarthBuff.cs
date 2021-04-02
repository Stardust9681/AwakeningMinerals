using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Potions
{
	// Ethereal Flames is an example of a buff that causes constant loss of life.
	// See ExamplePlayer.UpdateBadLifeRegen and ExampleGlobalNPC.UpdateLifeRegen for more information.
	public class EarthBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Earth Buff");
			Description.SetDefault("Life Regen");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 2;

			//player.buffTime[buffIndex] = 120;
        }
	}
}
