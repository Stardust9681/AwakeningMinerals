using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Mounts;

namespace AwakeningMinerals.Items.ItemMount
{
	public class WhiteWolfMount : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("White Moon");
			Tooltip.SetDefault("Summon a White Wolf Mount");
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
			item.mountType = MountType<Mounts.WhiteWolf>();
		}

    public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.AMToken>(), 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}