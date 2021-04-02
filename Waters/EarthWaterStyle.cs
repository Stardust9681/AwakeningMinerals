using Microsoft.Xna.Framework;
using AwakeningMinerals.Backgrounds;
using AwakeningMinerals.Dusts;
using AwakeningMinerals.Gores;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Waters
{
	public class EarthWaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
		{
			return Main.bgStyle == mod.GetSurfaceBgStyleSlot<EarthBiomeBgStyle>();
		}

		public override int ChooseWaterfallStyle()
		{
			return mod.GetWaterfallStyleSlot<EarthWaterfallStyle>();
		}

		public override int GetSplashDust()
		{
			return ModContent.DustType<EarthWaterSplash>();
		}

		public override int GetDropletGore()
		{
			return mod.GetGoreSlot<EarthWaterDroplet>();
		}

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 1f;
			b = 1f;
		}

		public override Color BiomeHairColor()
		{
			return Color.Green;
		}
	}
}