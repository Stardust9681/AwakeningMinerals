using AwakeningMinerals.Dusts;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using AwakeningMinerals.Items.AstralMoon;

namespace AwakeningMinerals.Tiles.ElementalBiomes.Trees
{
	public class AirTree : ModTree
	{
		private Mod mod => ModLoader.GetMod("AwakeningMinerals");

		public override int CreateDust() {
			return ModContent.DustType<AirDust>();
		}

		public override int GrowthFXGore() {
			return mod.GetGoreSlot("Gores/AirTreeFX");
		}

		public override int DropWood() {
			return ModContent.ItemType<Items.Air.AirWood>();
		}

		public override Texture2D GetTexture() {
			return mod.GetTexture("Tiles/ElementalBiomes/Trees/AirTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset) {
			return mod.GetTexture("Tiles/ElementalBiomes/Trees/AirTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame) {
			return mod.GetTexture("Tiles/ElementalBiomes/Trees/AirTree_Branches");
		}
	}
} 