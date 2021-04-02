using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AwakeningMinerals.Projectiles.Weapons.Legendary.Magic;

using AwakeningMinerals.Items.Projects;

namespace AwakeningMinerals.Items.Weapons.Legendary.Magic
{
	public class GrassStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grass staff");
            Tooltip.SetDefault("The legendary weapon of Poison");
		}		
		public override void SetDefaults()
		{

			item.mana = 10;
			item.UseSound = SoundID.Item8;
			item.useStyle = 5;
			item.damage = 50;
			item.useTime = 15;
			item.useAnimation = 30;

			item.width = 62;
			item.height = 62;

			item.knockBack = 4;
			Item.staff[item.type] = true;
			item.magic = true;
			item.autoReuse = true;
            item.value = Item.sellPrice(gold: 50);
			item.rare = ItemRarityID.Expert;
			item.noMelee = true;
			item.crit = 25;

			item.shoot = ModContent.ProjectileType<GrassStaffProj>();
			item.shootSpeed = 3f;
		}
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<MagicBookProject>(), 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
