using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items
{

    public class Lotus : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lotus");
            Tooltip.SetDefault("A strange force comes from this lotus");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.Expert;
            item.maxStack = 1;
        }
    }
}