using Microsoft.Xna.Framework;
using AwakeningMinerals.Backgrounds;
using AwakeningMinerals.Dusts;
using AwakeningMinerals.Gores;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Waters
{
	public class AstralMoonWaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
		{
			return Main.bgStyle == mod.GetSurfaceBgStyleSlot<AstralMoonBiomeBgStyle>();
		}

		public override int ChooseWaterfallStyle()
		{
			return mod.GetWaterfallStyleSlot<AstralMoonWaterfallStyle>();
		}

		public override int GetSplashDust()
		{
			return ModContent.DustType<AstralMoonWaterSplash>();
		}

		public override int GetDropletGore()
		{
			return mod.GetGoreSlot<AstralWaterDroplet>();
		}

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 1f;
			b = 1f;
		}

		public override Color BiomeHairColor()
		{
			return Color.MediumPurple;
		}
	}
}