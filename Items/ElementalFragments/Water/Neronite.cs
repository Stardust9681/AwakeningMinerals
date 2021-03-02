using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.ElementalFragments.Water
{

    public class Neronite : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Neronite");
            Tooltip.SetDefault("A strange stone green stone");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.value = Item.sellPrice(silver: 20);
            item.rare = ItemRarityID.Green;
            item.maxStack = 99;
        }
    }
}