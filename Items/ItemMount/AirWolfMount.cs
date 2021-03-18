using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Mounts;

namespace AwakeningMinerals.Items.ItemMount
{
	public class AirWolfMount : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Air Moon");
			Tooltip.SetDefault("Summon a Air Wolf Mount");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 30000;
			item.rare = 11;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = MountType<Mounts.AirWolf>();
		}
	}
}