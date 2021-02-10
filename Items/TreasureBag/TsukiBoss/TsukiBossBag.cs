using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Items.TreasureBag.TsukiBoss
{
    public class TsukiBossBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tsuki - Treasure Bag");
            Tooltip.SetDefault("Right click to open");
        }
        
        public override void SetDefaults()
        {
            item.maxStack = 99;
            item.consumable = true;
            item.width = 32;
            item.height = 32;
            item.rare = ItemRarityID.LightPurple;
            item.expert = true;


        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(1))
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.TsukiBossBody>());
                player.QuickSpawnItem(ModContent.ItemType<Items.TsukiBossLegs>());
                player.QuickSpawnItem(ModContent.ItemType<Items.TsukiBossMask>());

                player.QuickSpawnItem(mod.ItemType("Crystal"), Main.rand.Next(1, 10));
            }
        }

        public override int BossBagNPC => ModContent.NPCType<NPCs.Bosses.TsukiBoss>();
    }
}