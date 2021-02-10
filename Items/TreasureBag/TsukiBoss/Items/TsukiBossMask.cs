using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.TreasureBag.TsukiBoss.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class TsukiBossMask : ModItem
	{
		public override void SetDefaults() {
			item.width = 26;
			item.height = 20;
			item.rare = ItemRarityID.LightPurple;
			item.vanity = true;
			item.expert = true;
		}

		public override bool DrawHead() {
			return false;
		}
	}
}