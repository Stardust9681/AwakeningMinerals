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

    public class RangedBookProject : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ranged Book Project");
            Tooltip.SetDefault("Use it for craft ranged legendary weapons");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = Item.sellPrice(silver: 75);
            item.rare = ItemRarityID.Green;
            item.maxStack = 999;
        }
    }
}