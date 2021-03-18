using AwakeningMinerals.Dusts;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using AwakeningMinerals.Items.Water;

namespace AwakeningMinerals.Tiles.ElementalBiomes.Trees
{
	public class WaterTree : ModTree
	{
		private Mod mod => ModLoader.GetMod("AwakeningMinerals");

		public override int CreateDust() {
			return ModContent.DustType<WaterDust>();
		}

		public override int GrowthFXGore() {
			return mod.GetGoreSlot("Gores/WaterTreeFX");
		}

		public override int DropWood() {
			return ModContent.ItemType<Items.Water.WaterWood>();
		}

		public override Texture2D GetTexture() {
			return mod.GetTexture("Tiles/WaterBiome/Trees/WaterTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset) {
			return mod.GetTexture("Tiles/WaterBiome/Trees/WaterTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame) {
			return mod.GetTexture("Tiles/WaterBiome/Trees/WaterTree_Branches");
		}
	}
} 