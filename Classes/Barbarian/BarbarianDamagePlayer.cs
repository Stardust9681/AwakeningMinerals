using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace AwakeningMinerals.Classes.Barbarian
{
	// This class stores necessary player info for our custom damage class, such as damage multipliers, additions to knockback and crit, and our custom resource that governs the usage of the weapons of this damage class.
	public class BarbarianDamagePlayer : ModPlayer
	{
		public static BarbarianDamagePlayer ModPlayer(Player player) {
			return player.GetModPlayer<BarbarianDamagePlayer>();
		}

		// Vanilla only really has damage multipliers in code
		// And crit and knockback is usually just added to
		// As a modder, you could make separate variables for multipliers and simple addition bonuses
		public float BarbarianDamageAdd;
		public float BarbarianDamageMult = 1f;
		public float BarbarianKnockback;
		public int BarbarianCrit;

		// Here we include a custom resource, similar to mana or health.
		// Creating some variables to define the current value of our example resource as well as the current maximum value. We also include a temporary max value, as well as some variables to handle the natural regeneration of this resource.
		public int BarbarianResourceCurrent;
		public const int DefaultBarbarianResourceMax = 100;
		public int BarbarianResourceMax;
		public int BarbarianResourceMax2;
		public float BarbarianResourceRegenRate;
		internal int BarbarianResourceRegenTimer = 0;
		public static readonly Color HealBarbarianResource = new Color(187, 91, 201); // We can use this for CombatText, if you create an item that replenishes BarbarianResourceCurrent.

		/*
		In order to make the Barbarian Resource Barbarian straightforward, several things have been left out that would be needed for a fully functional resource similar to mana and health. 
		Here are additional things you might need to implement if you intend to make a custom resource:
		- Multiplayer Syncing: The current Barbarian doesn't require MP code, but pretty much any additional functionality will require this. ModPlayer.SendClientChanges and clientClone will be necessary, as well as SyncPlayer if you allow the user to increase BarbarianResourceMax.
		- Save/Load and increased max resource: You'll need to implement Save/Load to remember increases to your BarbarianResourceMax cap.
		- Resouce replenishment item: Use GlobalNPC.NPCLoot to drop the item. ModItem.OnPickup and ModItem.ItemSpace will allow it to behave like Mana Star or Heart. Use code similar to Player.HealEffect to spawn (and sync) a colored number suitable to your resource.
		*/

		public override void Initialize() {
			BarbarianResourceMax = DefaultBarbarianResourceMax;
		}

		public override void ResetEffects() {
			ResetVariables();
		}

		public override void UpdateDead() {
			ResetVariables();
		}

		private void ResetVariables() {
			BarbarianDamageAdd = 0f;
			BarbarianDamageMult = 1f;
			BarbarianKnockback = 0f;
			BarbarianCrit = 0;
			BarbarianResourceRegenRate = 1f;
			BarbarianResourceMax2 = BarbarianResourceMax;
		}

		public override void PostUpdateMiscEffects() {
			UpdateResource();
		}

		// Lets do all our logic for the custom resource here, such as limiting it, increasing it and so on.
		private void UpdateResource() {
			// For our resource lets make it regen slowly over time to keep it simple, let's use BarbarianResourceRegenTimer to count up to whatever value we want, then increase currentResource.
			BarbarianResourceRegenTimer++; //Increase it by 60 per second, or 1 per tick.

			// A simple timer that goes up to 3 seconds, increases the BarbarianResourceCurrent by 1 and then resets back to 0.
			if (BarbarianResourceRegenTimer > 180 * BarbarianResourceRegenRate) {
				BarbarianResourceCurrent += 1;
				BarbarianResourceRegenTimer = 0;
			}

			// Limit BarbarianResourceCurrent from going over the limit imposed by BarbarianResourceMax.
			BarbarianResourceCurrent = Utils.Clamp(BarbarianResourceCurrent, 0, BarbarianResourceMax2);
		}
	}
}
