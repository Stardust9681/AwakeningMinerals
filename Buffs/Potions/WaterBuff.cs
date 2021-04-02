using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Potions
{
	// Ethereal Flames is an example of a buff that causes constant loss of life.
	// See ExamplePlayer.UpdateBadLifeRegen and ExampleGlobalNPC.UpdateLifeRegen for more information.
	public class WaterBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Water Buff");
			Description.SetDefault("Water Walking buff, Fishing buff, Sonar buff, Crate buff");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
       	player.AddBuff(BuffID.WaterWalking, 1);
		player.AddBuff(BuffID.Fishing, 1);
		player.AddBuff(BuffID.Sonar, 1);
		player.AddBuff(BuffID.Crate, 1);

			//player.buffTime[buffIndex] = 120;
        }
	}
}
