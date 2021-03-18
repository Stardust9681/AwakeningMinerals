using AwakeningMinerals.Dusts;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using AwakeningMinerals.Items.Light;

namespace AwakeningMinerals.Tiles.ElementalBiomes.Trees
{
	public class LightTree : ModTree
	{
		private Mod mod => ModLoader.GetMod("AwakeningMinerals");

		public override int CreateDust() {
			return ModContent.DustType<LightDust>();
		}

		public override int GrowthFXGore() {
			return mod.GetGoreSlot("Gores/LightTreeFX");
		}

		public override int DropWood() {
			return ModContent.ItemType<Items.Light.LightWood>();
		}

		public override Texture2D GetTexture() {
			return mod.GetTexture("Tiles/LightBiome/Trees/LightTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset) {
			return mod.GetTexture("Tiles/LightBiome/Trees/LightTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame) {
			return mod.GetTexture("Tiles/LightBiome/Trees/LightTree_Branches");
		}
	}
} 