using AwakeningMinerals.Tiles.ElementalBiomes.Trees;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Tiles.ElementalBiomes
{
	public class DeathGrassTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = false;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			drop = ItemType<Items.AstralMoon.AstralMoonDirt>();
			AddMapEntry(new Color(25, 10, 50));
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			r = 0.60f;
			g = 0.55f;
			b = 0.90f;
		}

		public override void ChangeWaterfallStyle(ref int style) {
			style = mod.GetWaterfallStyleSlot("AstralMoonWaterfallStyle");
		}

		public override int SaplingGrowthType(ref int style) {
			style = 0;
			return ModContent.TileType<DeathSaplingTile>();
		}
	}
}