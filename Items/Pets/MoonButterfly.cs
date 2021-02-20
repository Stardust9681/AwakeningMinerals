using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Buffs;

namespace AwakeningMinerals.Items.Pets
{
    public class MoonButterfly : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Butterfly");
            Tooltip.SetDefault("Summon a pet - Moon Butterfly.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 40;
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("MoonButterflyProj");
            item.buffType = mod.BuffType("MoonButterflyBuff");
            item.rare = ItemRarityID.LightPurple;
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