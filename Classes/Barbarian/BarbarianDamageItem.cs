using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AwakeningMinerals.Classes.Barbarian
{
	// This class handles everything for our custom damage class
	// Any class that we wish to be using our custom damage class will derive from this class, instead of ModItem
	public abstract class BarbarianDamageItem : ModItem
	{
		public override bool CloneNewInstances => true;
		public int BarbarianResourceCost = 0;

		// Custom items should override this to set their defaults
		public virtual void SafeSetDefaults() {
		}

		// By making the override sealed, we prevent derived classes from further overriding the method and enforcing the use of SafeSetDefaults()
		// We do this to ensure that the vanilla damage types are always set to false, which makes the custom damage type work
		public sealed override void SetDefaults() {
			SafeSetDefaults();
			// all vanilla damage types must be false for custom damage types to work
			item.melee = true;
			item.ranged = false;
			item.magic = false;
			item.thrown = false;
			item.summon = false;

			item.rare = ItemRarityID.White;
		}

		// As a modder, you could also opt to make these overrides also sealed. Up to the modder
		public override void ModifyWeaponDamage(Player player, ref float add, ref float mult, ref float flat) {
			add += BarbarianDamagePlayer.ModPlayer(player).BarbarianDamageAdd;
			mult *= BarbarianDamagePlayer.ModPlayer(player).BarbarianDamageMult;
		}

		public override void GetWeaponKnockback(Player player, ref float knockback) {
			// Adds knockback bonuses
			knockback += BarbarianDamagePlayer.ModPlayer(player).BarbarianKnockback;
		}

		public override void GetWeaponCrit(Player player, ref int crit) {
			// Adds crit bonuses
			crit += BarbarianDamagePlayer.ModPlayer(player).BarbarianCrit;
		}

		// Because we want the damage tooltip to show our custom damage, we need to modify it
		public override void ModifyTooltips(List<TooltipLine> tooltips) {
			// Get the vanilla damage tooltip
			TooltipLine tt = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.mod == "Terraria");
			if (tt != null) {
				// We want to grab the last word of the tooltip, which is the translated word for 'damage' (depending on what language the player is using)
				// So we split the string by whitespace, and grab the last word from the returned arrays to get the damage word, and the first to get the damage shown in the tooltip
				string[] splitText = tt.text.Split(' ');
				string damageValue = splitText.First();
				string damageWord = splitText.Last();
				// Change the tooltip text
				tt.text = damageValue + " Barbarian " + damageWord;
			}

			if(BarbarianResourceCost > 0) {
				tooltips.Add(new TooltipLine(mod, "Barbarian Resource Cost", $"Uses {BarbarianResourceCost} Barbarian resource"));
			}
		}

		// Make sure you can't use the item if you don't have enough resource and then use 10 resource otherwise.
		public override bool CanUseItem(Player player) {
			var BarbarianDamagePlayer = player.GetModPlayer<BarbarianDamagePlayer>();

			if (BarbarianDamagePlayer.BarbarianResourceCurrent >= BarbarianResourceCost) {
				BarbarianDamagePlayer.BarbarianResourceCurrent -= BarbarianResourceCost;
				return true;
			}
			return false;
		}
	}
}
