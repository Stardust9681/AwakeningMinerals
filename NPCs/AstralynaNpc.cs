using System;
using AwakeningMinerals.Dusts;
using AwakeningMinerals.Items;
using AwakeningMinerals.Items.Weapons;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace AwakeningMinerals.NPCs
{
	// [AutoloadHead] and npc.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
	[AutoloadHead]
	public class NyanaNpc : ModNPC
	{
		public override string Texture => "AwakeningMinerals/NPCs/AstralynaNpc";

		public override bool Autoload(ref string name) {
			name = "Astralyna";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults() {
			// DisplayName automatically assigned from .lang files, but the commented line below is the normal approach.
			// DisplayName.SetDefault("Example Person");
			Main.npcFrameCount[npc.type] = 23;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults() {
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Angler;
		}

		public override void HitEffect(int hitDirection, double damage) {
			int num = npc.life > 0 ? 1 : 5;
			for (int k = 0; k < num; k++) {
				Dust.NewDust(npc.position, npc.width, npc.height, ModContent.DustType<StarDust>());
			}
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money) {
			for (int k = 0; k < 255; k++) {
				Player player = Main.player[k];
				if (!player.active) {
					continue;
				}

				foreach (Item item in player.inventory) {
					if (item.type == ModContent.ItemType<Items.Crystal>()) {
						return true;
					}
				}
			}
			return false;
		}

		public override string TownNPCName() {
			switch (WorldGen.genRand.Next(4)) {
				case 0:
					return "Astralyna";
				case 1:
					return "Astralyna";
				case 2:
					return "Astralyna";
				case 3:
					return "Astralyna";
				default:
					return "Astralyna";
			}
		}

		public override void FindFrame(int frameHeight) {
			/*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
		}

		public override string GetChat()
		{
			switch (Main.rand.Next(4)) {
				case 0:
					return "Thank you for have me saved.";
				default:
					return "May the blessing of the Moon be with you";
			}
		}

		/* 
		// Consider using this alternate approach to choosing a random thing. Very useful for a variety of use cases.
		// The WeightedRandom class needs "using Terraria.Utilities;" to use
		public override string GetChat()
		{
			WeightedRandom<string> chat = new WeightedRandom<string>();

			int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
			if (partyGirl >= 0 && Main.rand.NextBool(4))
			{
				chat.Add("Can you please tell " + Main.npc[partyGirl].GivenName + " to stop decorating my house with colors?");
			}
			chat.Add("Sometimes I feel like I'm different from everyone else here.");
			chat.Add("What's your favorite color? My favorite colors are white and black.");
			chat.Add("What? I don't have any arms or legs? Oh, don't be ridiculous!");
			chat.Add("This message has a weight of 5, meaning it appears 5 times more often.", 5.0);
			chat.Add("This message has a weight of 0.1, meaning it appears 10 times as rare.", 0.1);
			return chat; // chat is implicitly cast to a string. You can also do "return chat.Get();" if that makes you feel better
		}
		*/

		public override void SetChatButtons(ref string button, ref string button2) {
			button = Language.GetTextValue("LegacyInterface.28");
			//button2 = "Awesomeify";
			if (Main.LocalPlayer.HasItem(ItemID.HiveBackpack))
				button = "Upgrade " + Lang.GetItemNameValue(ItemID.HiveBackpack);
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop) 
		{
			if (firstButton) 
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot) 
		{
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.SummonTsuki>());
			
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Tools.Moon.MoonAxe>());
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Tools.Moon.MoonHammer>());
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Tools.Moon.MoonPickaxe>());

			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Tools.AstralMoonSolution>());

			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Projects.LegendaryChest>());

			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Projects.MagicBookProject>());
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Projects.SummonBookProject>());
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Projects.MeleeBookProject>());
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Projects.RangedBookProject>());
		}

		public override void NPCLoot() {
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Lotus>());
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback) {
			damage = 20;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown) {
			cooldown = 30;
			randExtraCooldown = 30;
		}

		//public override void TownNPCAttackProj(ref int projType, ref int attackDelay) {
		//	projType = ModContent.ProjectileType<MoonProj>();
		//	attackDelay = 1;
		//}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset) {
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}
