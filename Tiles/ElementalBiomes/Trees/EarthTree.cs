using AwakeningMinerals.Dusts;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using AwakeningMinerals.Items.Earth;

namespace AwakeningMinerals.Tiles.ElementalBiomes.Trees
{
	public class EarthTree : ModTree
	{
		private Mod mod => ModLoader.GetMod("AwakeningMinerals");

		public override int CreateDust() {
			return ModContent.DustType<EarthDust>();
		}

		public override int GrowthFXGore() {
			return mod.GetGoreSlot("Gores/EarthTreeFX");
		}

		public override int DropWood() {
			return ModContent.ItemType<Items.Earth.EarthWood>();
		}

		public override Texture2D GetTexture() {
			return mod.GetTexture("Tiles/EarthBiome/Trees/EarthTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset) {
			return mod.GetTexture("Tiles/EarthBiome/Trees/EarthTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame) {
			return mod.GetTexture("Tiles/EarthBiome/Trees/EarthTree_Branches");
		}
	}
} 