using AwakeningMinerals.Items;
using AwakeningMinerals.NPCs;
using AwakeningMinerals.Tiles.ElementalBiomes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using System.Linq;
using static Terraria.ModLoader.ModContent;
using System;

namespace AwakeningMinerals
{
	public class AwakeningMineralsWorld : ModWorld
	{
		//Tiles
		public static int AstralMoonTiles;
		public static int IceBiomeTiles;
		public static int FireBiomeTiles;
		public static int EarthBiomeTiles;
		public static int DeathBiomeTiles;
		public static int LightBiomeTiles;
		public static int ThunderBiomeTiles;
		public static int WaterBiomeTiles;
		public static int AirBiomeTiles;

		//Zone
		public static int ZoneAstralMoon;
		public static int ZoneIceBiome;
		public static int ZoneFireBiome;
		public static int ZoneEarthBiome;
		public static int ZoneDeathBiome;
		public static int ZoneLightBiome;
		public static int ZoneThunderBiome;
		public static int ZoneWaterBiome;
		public static int ZoneAirBiome;


		private void GenerateIperOre(GenerationProgress progress)
		{
			progress.Message = "Spawning Iper Ore";
			for(var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
			{
				int x = WorldGen.genRand.Next(200, Main.maxTilesX - 200);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY - 500);

				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(4, 7), WorldGen.genRand.Next(3, 6),
					ModContent.TileType<Tiles.Minerals.Ores.IperOreTile>());
			}

			progress.Message = "Spawning Vex Ore";
			for(var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
			{
				int x = WorldGen.genRand.Next(200, Main.maxTilesX - 200);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY - 500);

				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(4, 7), WorldGen.genRand.Next(3, 6),
					ModContent.TileType<Tiles.Minerals.Ores.VexOreTile>());
			}

			progress.Message = "Spawning Xony Ore";
			for(var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
			{
				int x = WorldGen.genRand.Next(200, Main.maxTilesX - 200);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY - 500);

				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(4, 7), WorldGen.genRand.Next(3, 6),
					ModContent.TileType<Tiles.Minerals.Ores.XonyOreTile>());
			}

			progress.Message = "Spawning Zeky Ore";
			for(var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
			{
				int x = WorldGen.genRand.Next(200, Main.maxTilesX - 200);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY - 500);

				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(4, 7), WorldGen.genRand.Next(3, 6),
					ModContent.TileType<Tiles.Minerals.Ores.ZekyOreTile>());
			}
		}

		public override void ResetNearbyTileEffects() {
			AwakeningMineralsPlayer modPlayer = Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>();
			AstralMoonTiles = 0;
			IceBiomeTiles = 0;
			FireBiomeTiles = 0;
			DeathBiomeTiles = 0;
			EarthBiomeTiles = 0;
			LightBiomeTiles = 0;
			ThunderBiomeTiles = 0;
			WaterBiomeTiles = 0;
			AirBiomeTiles = 0;
		}

		public override void TileCountsAvailable(int[] tileCounts) {
			// Here we count various tiles towards ZoneExample
			AstralMoonTiles = tileCounts[ModContent.TileType<AstralMoonGrassTile>()] + 
			tileCounts[ModContent.TileType<AstralMoonSandTile>()] +
			tileCounts[ModContent.TileType<AstralMoonDirtTile>()];

			IceBiomeTiles = tileCounts[ModContent.TileType<IceGrassTile>()] + 
			tileCounts[ModContent.TileType<IceSandTile>()] +
			tileCounts[ModContent.TileType<IceDirtTile>()];

			FireBiomeTiles = tileCounts[ModContent.TileType<FireGrassTile>()] + 
			tileCounts[ModContent.TileType<FireSandTile>()] +
			tileCounts[ModContent.TileType<FireDirtTile>()];

			DeathBiomeTiles = tileCounts[ModContent.TileType<DeathGrassTile>()] + 
			tileCounts[ModContent.TileType<DeathSandTile>()] +
			tileCounts[ModContent.TileType<DeathDirtTile>()];

			EarthBiomeTiles = tileCounts[ModContent.TileType<EarthGrassTile>()] + 
			tileCounts[ModContent.TileType<EarthSandTile>()] +
			tileCounts[ModContent.TileType<EarthDirtTile>()];

			LightBiomeTiles = tileCounts[ModContent.TileType<LightGrassTile>()] + 
			tileCounts[ModContent.TileType<LightSandTile>()] +
			tileCounts[ModContent.TileType<LightDirtTile>()];

			ThunderBiomeTiles = tileCounts[ModContent.TileType<ThunderGrassTile>()] + 
			tileCounts[ModContent.TileType<ThunderSandTile>()] +
			tileCounts[ModContent.TileType<ThunderDirtTile>()];

			WaterBiomeTiles = tileCounts[ModContent.TileType<WaterGrassTile>()] + 
			tileCounts[ModContent.TileType<WaterSandTile>()] +
			tileCounts[ModContent.TileType<WaterDirtTile>()];

			AirBiomeTiles = tileCounts[ModContent.TileType<AirGrassTile>()] + 
			tileCounts[ModContent.TileType<AirSandTile>()] +
			tileCounts[ModContent.TileType<AirDirtTile>()];
		}
	}
}