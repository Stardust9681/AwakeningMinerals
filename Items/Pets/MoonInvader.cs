using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Buffs;

namespace AwakeningMinerals.Items.Pets
{
    public class MoonInvader : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Invader");
            Tooltip.SetDefault("Summon a pet - Moon Butterfly.");
        }

        public override void SetDefaults()
        {
			item.damage = 0;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.shoot = ModContent.ProjectileType<Projectiles.Pets.MoonInvaderProj>();
			item.width = 16;
			item.height = 30;
			item.UseSound = SoundID.Item2;
			item.useAnimation = 20;
			item.useTime = 20;
			item.rare = ItemRarityID.LightPurple;
			item.noMelee = true;
            item.value = Item.sellPrice(silver: 75);
			item.buffType = ModContent.BuffType<Buffs.Pets.MoonInvaderBuff>();
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}