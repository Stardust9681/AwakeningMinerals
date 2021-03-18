using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Wings
{
	[AutoloadEquip(EquipType.Wings)]
	public class AstralWings : ModItem
	{
         public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			TooltipLine line = new TooltipLine(mod, "ItemName", "AM Contents");
			line.overrideColor = new Color(250, 200, 255);
			tooltips.Add(line);
			foreach (TooltipLine line2 in tooltips) {
				if (line2.mod == "Terraria" && line2.Name == "ItemName") {
					line2.overrideColor = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
					break;
				}
			}
		}
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Astral wings");
		}

		public override void SetDefaults()
		{
			item.width = 60;
			item.height = 48;
			item.value = Item.sellPrice(gold: 5);
			item.rare = ItemRarityID.Expert;
			item.expert = true;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 90;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 150f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 5f;
			acceleration *= 2.5f;
		}
	}
}