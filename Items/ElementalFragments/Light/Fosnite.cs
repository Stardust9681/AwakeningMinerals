using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.ElementalFragments.Light
{

    public class Fosnite : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fosnite");
            Tooltip.SetDefault("A strange holy stone");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.value = Item.sellPrice(silver: 20);
            item.rare = ItemRarityID.Orange;
            item.maxStack = 99;
        }
    }
}