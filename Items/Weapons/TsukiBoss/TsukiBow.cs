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

namespace AwakeningMinerals.Items.Weapons.TsukiBoss
{

    public class TsukiBow : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Moon Bow");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 50;
            item.rare = ItemRarityID.LightPurple;
            item.value = Item.sellPrice(gold: 75);

            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;

            item.noMelee = true;
            item.ranged = true;
            item.damage = 20;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = 1;
            item.shootSpeed = 7.5f;
            item.crit = 25;
        }
    }
}
