using AwakeningMinerals.Dusts;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using AwakeningMinerals.Items.Thunder;

namespace AwakeningMinerals.Tiles.ElementalBiomes.Trees
{
	public class ThunderTree : ModTree
	{
		private Mod mod => ModLoader.GetMod("AwakeningMinerals");

		public override int CreateDust() {
			return ModContent.DustType<ThunderDust>();
		}

		public override int GrowthFXGore() {
			return mod.GetGoreSlot("Gores/ThunderTreeFX");
		}

		public override int DropWood() {
			return ModContent.ItemType<Items.Thunder.ThunderWood>();
		}

		public override Texture2D GetTexture() {
			return mod.GetTexture("Tiles/ThunderBiome/Trees/ThunderTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset) {
			return mod.GetTexture("Tiles/ThunderBiome/Trees/ThunderTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame) {
			return mod.GetTexture("Tiles/ThunderBiome/Trees/ThunderTree_Branches");
		}
	}
} 