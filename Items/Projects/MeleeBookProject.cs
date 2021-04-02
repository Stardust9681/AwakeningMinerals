using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Projects
{

    public class MeleeBookProject : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Melee Book Project");
            Tooltip.SetDefault("Use it for craft melee legendary weapons");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.value = Item.sellPrice(silver: 75);
            item.rare = ItemRarityID.Red;
            item.maxStack = 99;
        }
    }
}