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

namespace AwakeningMinerals.NPCs.ElementalBiome.IceBiome.Animals

{

	public class IceBird : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice bird");
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 22;
			npc.damage = 0;
			npc.defense = 0;
			npc.lifeMax = 5;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/HitSlime");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCDeath/DeathSlime");
			npc.value = 60f;
			npc.knockBackResist = 0.08f;
			npc.aiStyle = 24;
			aiType = NPCID.BirdBlue;
			animationType = NPCID.BirdBlue;
			Main.npcFrameCount[npc.type] = 5;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			Tile tile = Main.tile[spawnInfo.spawnTileX, spawnInfo.spawnTileY];
			return (spawnInfo.player.GetModPlayer<AwakeningMineralsPlayer>().ZoneIceBiome) ? 1f : 0f;
		}
	}
}
