using Microsoft.Xna.Framework;
using AwakeningMinerals.Backgrounds;
using AwakeningMinerals.Dusts;
using AwakeningMinerals.Gores;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Waters
{
	public class ThunderWaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
		{
			return Main.bgStyle == mod.GetSurfaceBgStyleSlot<ThunderBiomeBgStyle>();
		}

		public override int ChooseWaterfallStyle()
		{
			return mod.GetWaterfallStyleSlot<ThunderWaterfallStyle>();
		}

		public override int GetSplashDust()
		{
			return ModContent.DustType<ThunderWaterSplash>();
		}

		public override int GetDropletGore()
		{
			return mod.GetGoreSlot<ThunderWaterDroplet>();
		}

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 1f;
			b = 1f;
		}

		public override Color BiomeHairColor()
		{
			return Color.Yellow;
		}
	}
}