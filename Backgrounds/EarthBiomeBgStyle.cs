using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Backgrounds
{
	public class EarthBiomeBgStyle : ModSurfaceBgStyle
	{
		public override bool ChooseBgStyle() {
			return !Main.gameMenu && Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>().ZoneEarthBiome;
		}

		// Use this to keep far Backgrounds like the mountains.
		public override void ModifyFarFades(float[] fades, float transitionSpeed) {
			for (int i = 0; i < fades.Length; i++) {
				if (i == Slot) {
					fades[i] += transitionSpeed;
					if (fades[i] > 1f) {
						fades[i] = 1f;
					}
				}
				else {
					fades[i] -= transitionSpeed;
					if (fades[i] < 0f) {
						fades[i] = 0f;
					}
				}
			}
		}

		public override int ChooseFarTexture() {
			return mod.GetBackgroundSlot("Backgrounds/EarthBiomeFar");
		}

		private static int SurfaceFrameCounter;
		private static int SurfaceFrame;
		public override int ChooseMiddleTexture() {
			if (++SurfaceFrameCounter > 12) {
				SurfaceFrame = (SurfaceFrame + 1) % 4;
				SurfaceFrameCounter = 0;
			}
			switch (SurfaceFrame) {
				case 0:
					return mod.GetBackgroundSlot("Backgrounds/EarthBiomeMid0");
				case 1:
					return mod.GetBackgroundSlot("Backgrounds/EarthBiomeMid1");
				case 2:
					return mod.GetBackgroundSlot("Backgrounds/EarthBiomeMid2");
				case 3:
					return mod.GetBackgroundSlot("Backgrounds/EarthBiomeMid3");
				default:
					return -1;
			}
		}

		public override int ChooseCloseTexture(ref float scale, ref double parallax, ref float a, ref float b) {
			return mod.GetBackgroundSlot("Backgrounds/EarthBiomeClose");
		}
	}
}