using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.Debuffs
{
	public class FireDebuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Fire Debuff");
			Description.SetDefault("Life Regen -4");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen -= 5;

			//player.buffTime[buffIndex] = 120;
        }
	}
}
