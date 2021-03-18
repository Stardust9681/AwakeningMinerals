using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.Ancient
{

    public class AncientFlower : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Flower");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 20;
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(copper: 50);
            item.maxStack = 999;
        }
    }
}