﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class ForgottenCultistLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forgotten Cultist - Legs");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 1;
			item.vanity = true;
		}
	}
}
