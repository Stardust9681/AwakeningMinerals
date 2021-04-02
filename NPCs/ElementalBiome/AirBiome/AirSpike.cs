using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AwakeningMinerals.Buffs.Debuffs;

namespace AwakeningMinerals.NPCs.ElementalBiome.AirBiome

{

	public class AirSpike : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Air Spike");
		}

		public override void SetDefaults()
		{
			npc.width = 44;
			npc.height = 34;
			npc.damage = 60;
			npc.defense = 25;
			npc.lifeMax = 200;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/HitSlime");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCDeath/DeathSlime");
			npc.value = 60f;
			npc.knockBackResist = 0.08f;
			npc.aiStyle = 1;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
			Main.npcFrameCount[npc.type] = 2;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			Tile tile = Main.tile[spawnInfo.spawnTileX, spawnInfo.spawnTileY];
			return (spawnInfo.player.GetModPlayer<AwakeningMineralsPlayer>().ZoneAirBiome) ? 1f : 0f;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = mod.DustType("ChaosNpcDust");
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Air.Stone.AirStone>(), Main.rand.Next(1, 6));
		}
		public override void OnHitPlayer(Player target, int damage, bool crit)
		{
			if (Main.rand.Next(3) == 0) {
				target.AddBuff(ModContent.BuffType<AirDebuff>(), 180);
			}
		}
	}
}
