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

    public class Crystal : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal");
            Tooltip.SetDefault("A small crystal fregment");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 24;
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.LightPurple;
            item.maxStack = 99;
        }
    }
}