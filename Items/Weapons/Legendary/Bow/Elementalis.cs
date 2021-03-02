using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Weapons.Legendary.Bow
{

    public class Elementalist : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Elementalist");
            Tooltip.SetDefault("The legendary weapon of Elementals");
        }

        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 62;
            item.rare = ItemRarityID.Expert;
            item.value = Item.sellPrice(gold: 75);

            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;

            item.noMelee = true;
            item.ranged = true;
            item.damage = 40;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = 1;
            item.shootSpeed = 10f;
            item.crit = 25;
        }
    }
}
