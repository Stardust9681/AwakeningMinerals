using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.ItemTek.Boss
{

    public class MetalPlate : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Metal Plate");
            Tooltip.SetDefault("A metal plate dropped by mechanical bosses");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.Pink;
            item.maxStack = 99;
        }
    }
}