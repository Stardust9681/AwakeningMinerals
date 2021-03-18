using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.Items.AstralMoon
{

    public class UnknownScale : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unknown Scale");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.rare = ItemRarityID.LightPurple;
            item.value = Item.sellPrice(copper: 50);
            item.maxStack = 999;
        }
    }
}