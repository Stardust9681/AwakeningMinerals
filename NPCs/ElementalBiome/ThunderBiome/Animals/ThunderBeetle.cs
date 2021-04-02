using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Dusts;
using AwakeningMinerals.Buffs;

namespace AwakeningMinerals.NPCs.ElementalBiome.ThunderBiome.Animals
{

	public class ThunderBeetle : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thunder beetle");
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 26;
			npc.damage = 0;
			npc.defense = 0;
			npc.lifeMax = 5;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/HitSlime");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCDeath/DeathSlime");
			npc.value = 60f;
			npc.knockBackResist = 0.08f;
			npc.aiStyle = 7;
			aiType = NPCID.LacBeetle;
			animationType = NPCID.LacBeetle;
			Main.npcFrameCount[npc.type] = 2;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			Tile tile = Main.tile[spawnInfo.spawnTileX, spawnInfo.spawnTileY];
			return (spawnInfo.player.GetModPlayer<AwakeningMineralsPlayer>().ZoneThunderBiome) ? 1f : 0f;
		}
	}
}