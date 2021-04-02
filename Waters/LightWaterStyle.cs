using Microsoft.Xna.Framework;
using AwakeningMinerals.Backgrounds;
using AwakeningMinerals.Dusts;
using AwakeningMinerals.Gores;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Waters
{
	public class LightWaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
		{
			return Main.bgStyle == mod.GetSurfaceBgStyleSlot<LightBiomeBgStyle>();
		}

		public override int ChooseWaterfallStyle()
		{
			return mod.GetWaterfallStyleSlot<LightWaterfallStyle>();
		}

		public override int GetSplashDust()
		{
			return ModContent.DustType<LightWaterSplash>();
		}

		public override int GetDropletGore()
		{
			return mod.GetGoreSlot<LightWaterDroplet>();
		}

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 1f;
			b = 1f;
		}

		public override Color BiomeHairColor()
		{
			return Color.LightYellow;
		}
	}
}