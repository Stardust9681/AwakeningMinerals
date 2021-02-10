using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Wings
{
	[AutoloadEquip(EquipType.Wings)]
	public class TsukiWings : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Moon crystal wings");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 16;
			item.value = Item.sellPrice(gold: 5);
			item.rare = ItemRarityID.LightPurple;
			item.expert = true;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 150;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 5f;
			acceleration *= 2.5f;
		}
	}
}