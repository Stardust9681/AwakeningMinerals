using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Dusts;

namespace AwakeningMinerals.NPCs.Bosses.TsukiBoss
{

	public class TsukiRunner : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tsuki's Runner");
		}

		public override void SetDefaults()
		{
			npc.width = 80;
			npc.height = 30;
			npc.damage = 10;
			npc.defense = 8;
			npc.lifeMax = 125;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/HitBasilisk");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCDeath/DeathBasilisk");
			npc.value = 60f;
			npc.knockBackResist = 0.05f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertBeast;
			animationType = NPCID.DesertBeast;
			Main.npcFrameCount[npc.type] = 8;
		}
		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = mod.DustType("TsukiDust");
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
	}
}