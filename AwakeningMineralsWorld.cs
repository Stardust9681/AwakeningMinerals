using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System.Collections.Generic;
using System.IO;

namespace AwakeningMinerals
{
	public class AwakeningMineralsWorld : ModWorld
	{
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex  = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if(shiniesIndex != -1)
			{
				tasks.Insert(shiniesIndex + 1, new PassLegacy("Iper Ore Spawn", GenerateIperOre));
			}
        }

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
	}
}