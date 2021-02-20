using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Buffs.SpecialItems
{
    public class GoldenStatueDownloadsBuff : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Golden Buff (Special Buff)");
            Description.SetDefault("All damages (Minion, Magic, Melee, Ranged) = +10%\nSpeed Movement = +10%\nLife = 2 Hearts\nMana = 2 Stars\nMana Regen\nLife Regen");
            Main.buffNoTimeDisplay[Type] = true;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.allDamage += 0.1f;
            player.statLifeMax2 += 20;
            player.statManaMax2 += 40;
            player.statDefense += 10;
            player.lifeRegen = 3;
            player.manaRegen = 3;
            player.moveSpeed += 0.1f;
        }
    }
}