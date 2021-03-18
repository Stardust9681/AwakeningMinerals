using AwakeningMinerals.Dusts;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using AwakeningMinerals.Items.Death;

namespace AwakeningMinerals.Tiles.ElementalBiomes.Trees
{
	public class DeathTree : ModTree
	{
		private Mod mod => ModLoader.GetMod("AwakeningMinerals");

		public override int CreateDust() {
			return ModContent.DustType<DeathDust>();
		}

		public override int GrowthFXGore() {
			return mod.GetGoreSlot("Gores/DeathTreeFX");
		}

		public override int DropWood() {
			return ModContent.ItemType<Items.Death.DeathWood>();
		}

		public override Texture2D GetTexture() {
			return mod.GetTexture("Tiles/DeathBiome/Trees/DeathTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset) {
			return mod.GetTexture("Tiles/DeathBiome/Trees/DeathTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame) {
			return mod.GetTexture("Tiles/DeathBiome/Trees/DeathTree_Branches");
		}
	}
} 