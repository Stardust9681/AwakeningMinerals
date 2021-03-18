using AwakeningMinerals.Dusts;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using AwakeningMinerals.Items.Fire;

namespace AwakeningMinerals.Tiles.ElementalBiomes.Trees
{
	public class FireTree : ModTree
	{
		private Mod mod => ModLoader.GetMod("AwakeningMinerals");

		public override int CreateDust() {
			return ModContent.DustType<FireDust>();
		}

		public override int GrowthFXGore() {
			return mod.GetGoreSlot("Gores/FireTreeFX");
		}

		public override int DropWood() {
			return ModContent.ItemType<Items.Fire.FireWood>();
		}

		public override Texture2D GetTexture() {
			return mod.GetTexture("Tiles/FireBiome/Trees/FireTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset) {
			return mod.GetTexture("Tiles/FireBiome/Trees/FireTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame) {
			return mod.GetTexture("Tiles/FireBiome/Trees/FireTree_Branches");
		}
	}
} 