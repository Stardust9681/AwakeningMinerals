using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.ElementalFragments.Ice
{

    public class Pagosnite : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pagosnite");
            Tooltip.SetDefault("A strange blue stone");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 26;
            item.value = Item.sellPrice(silver: 20);
            item.rare = ItemRarityID.Blue;
            item.maxStack = 99;
        }
    }
}