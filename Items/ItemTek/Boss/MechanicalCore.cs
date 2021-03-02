using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.ItemTek.Boss
{
	public class MechanicalCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mechanical Core");
            Tooltip.SetDefault("A mechanical core dropped by mechanical bosses");
			// ticksperframe, frameCount
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
			ItemID.Sets.AnimatesAsSoul[item.type] = true;
			ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		// TODO -- Velocity Y smaller, post NewItem?
		public override void SetDefaults()
		{
			Item refItem = new Item();
			refItem.SetDefaults(ItemID.SoulofNight);
			item.width = refItem.width;
			item.height = refItem.height;
			item.maxStack = 99;
            item.value = Item.sellPrice(gold: 1);
			item.rare = ItemRarityID.Pink;
		}
		public override void PostUpdate()
		{
			Lighting.AddLight(item.Center, Color.Red.ToVector3() * 0.55f * Main.essScale);
		}
	}

}