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

	public class ThunderSnail : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thunder snail");
		}

		public override void SetDefaults()
		{
			npc.width = 27;
			npc.height = 19;
			npc.damage = 0;
			npc.defense = 0;
			npc.lifeMax = 5;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/HitSlime");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCDeath/DeathSlime");
			npc.value = 60f;
			npc.knockBackResist = 0.08f;
			npc.aiStyle = 67;
			aiType = NPCID.Snail;
			animationType = NPCID.Snail;
			Main.npcFrameCount[npc.type] = 6;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			Tile tile = Main.tile[spawnInfo.spawnTileX, spawnInfo.spawnTileY];
			return (spawnInfo.player.GetModPlayer<AwakeningMineralsPlayer>().ZoneThunderBiome) ? 1f : 0f;
		}
	}
}
