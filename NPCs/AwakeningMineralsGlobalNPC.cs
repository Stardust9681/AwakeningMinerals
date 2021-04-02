using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AwakeningMinerals.NPCs
{
	public class AwakeningMineralsGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc) 
        {
            //Space
            if (npc.type == NPCID.Harpy)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Air.Aeranite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.WyvernHead)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Air.Aeranite>(), Main.rand.Next(1, 2));
            }

            //Surface
            if (npc.type == NPCID.GreenSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BlueSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.PurpleSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.PossessedArmor)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.WanderingEye)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Wraith)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Werewolf)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.HoppinJack)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GoblinScout)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.KingSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Bunny)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Squirrel)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SquirrelRed)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SquirrelGold)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Bird)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BirdBlue)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BirdRed)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Duck)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Duck2)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Goldfish)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Butterfly)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Firefly)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Grasshopper)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Worm)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GoldBird)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GoldBunny)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GoldGrasshopper)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GoldWorm)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GoldfishWalker)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }

            //Snow
			if (npc.type == NPCID.IceSlime) 
            {
				Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.ZombieEskimo)
            {
    			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CorruptPenguin)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CrimsonPenguin)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.IceElemental)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Wolf)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.IceGolem)
            {
               Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.Penguin)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }

            //Ice
            if (npc.type == NPCID.IceBat)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SnowFlinx)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.UndeadViking)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.UndeadMiner)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CyanBeetle)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Nymph)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.ArmoredViking)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.IceTortoise)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
            }

            //Hell
            if (npc.type == NPCID.Hellbat)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.LavaSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.FireImp)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Demon)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.VoodooDemon)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BoneSerpentHead)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.WallofFlesh)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Mimic)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DemonTaxCollector)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Lavabat)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.RedDevil)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
            }

            //Desert
            if (npc.type == NPCID.SandSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Vulture)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Antlion)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Mummy)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DarkMummy)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.LightMummy)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Scorpion)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.ScorpionBlack)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }

            //Underground Desert
            if (npc.type == NPCID.WalkingAntlion)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.FlyingAntlion)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.TombCrawlerHead)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DesertBeast)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DesertScorpionWalk)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DesertLamiaDark)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DesertLamiaLight)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DuneSplicerHead)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DesertGhoul)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DesertGhoulCorruption)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DesertGhoulCrimson)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DesertGhoulHallow)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DesertDjinn)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Thunder.Vrontinite>(), Main.rand.Next(1, 2));
            }

            //Corruption
            if (npc.type == NPCID.EaterofSouls)
            {
               Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.CorruptGoldfish)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.DevourerHead)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.EaterofWorldsHead)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.Corruptor)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.CorruptSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.Slimer)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.SeekerHead)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.Slimer2)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.SandsharkCorrupt)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.DarkMummy)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }

            //Underground Corruption
            if (npc.type == NPCID.CursedHammer)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.Clinger)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.BigMimicCorruption)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.PigronCorruption)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }

            //Crimson
            if (npc.type == NPCID.BloodCrawler)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.CrimsonGoldfish)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.FaceMonster)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.Crimera)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2)); 
            }
            if (npc.type == NPCID.BrainofCthulhu)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Herpling)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Crimslime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BloodJelly)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BloodFeeder)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SandsharkCrimson)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }

            //Underground Crimson
            if (npc.type == NPCID.CrimsonAxe)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.IchorSticker)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.FloatyGross)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BigMimicCrimson)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.PigronCrimson)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
            }

            //Bee Hive
            if (npc.type == NPCID.Bee)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }

            //Granite Cave
            if (npc.type == NPCID.GraniteGolem)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GraniteFlyer)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }

            //Marble Cave
            if (npc.type == NPCID.GreekSkeleton)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Medusa)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }

            //Jungle Temple
            if (npc.type == NPCID.Lihzahrd)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.FlyingSnake)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Golem)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }

            //Meteorite
            if (npc.type == NPCID.MeteorHead)
            {
                int choice = Main.rand.Next (2);
                if (choice == 0)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
                }
                if (choice == 1)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
                }
            }

            //Spider Cave
            if (npc.type == NPCID.WallCreeper)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.WebbedStylist)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BlackRecluse)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }

            //Jungle
            if (npc.type == NPCID.JungleSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.JungleBat)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Piranha)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Snatcher)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Zombie)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DemonEye)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DoctorBones)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Frog)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GoldFrog)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Grubby)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Sluggy)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Buggy)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Derpling)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GiantTortoise)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GiantFlyingFox)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.AnglerFish)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Arapaima)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.AngryTrapper)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }

            //Underground Jungle
            if (npc.type == NPCID.Hornet)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.ManEater)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SpikedJungleSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.LacBeetle)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.QueenBee)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.JungleCreeper)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Moth)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Plantera)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }

            //Dungeon
            if (npc.type == NPCID.Skeleton)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.OldMan)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BoundMechanic)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.AngryBones)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DarkCaster)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CursedSkull)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DungeonSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SpikeBall)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BlazingWheel)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DungeonGuardian)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BlueArmoredBones)
            {
                int choice = Main.rand.Next(2);
                if (choice == 0)
                {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
                }
                if (choice == 1)
                {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Ice.Pagosnite>(), Main.rand.Next(1, 2));
                }
            }
            if (npc.type == NPCID.RustyArmoredBonesAxe)
            {
                int choice = Main.rand.Next (2);
                if (choice == 0)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
                }
                if (choice == 1)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Death.Skonite>(), Main.rand.Next(1, 2));
                }
            }
            if (npc.type == NPCID.HellArmoredBones)
            {
                int choice = Main.rand.Next (2);
                if (choice == 0)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
                }
                if (choice == 1)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Fire.Fotianite>(), Main.rand.Next(1, 2));
                }
            }
            if (npc.type == NPCID.Paladin)
            {
                int choice = Main.rand.Next (2);
                if (choice == 0)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
                }
                if (choice == 1)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
                }
            }
            if (npc.type == NPCID.Necromancer)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.RaggedCaster)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DiabolistRed)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DiabolistWhite)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SkeletonCommando)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SkeletonSniper)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.TacticalSkeleton)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GiantCursedSkull)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BoneLee)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DungeonSpirit)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CultistDevote)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CultistArcherBlue)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CultistArcherWhite)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CultistBoss)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }

            //Ocean
            if (npc.type == NPCID.SleepingAngler)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Water.Neronite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.PinkJellyfish)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Water.Neronite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Crab)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Water.Neronite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Squid)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Water.Neronite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SeaSnail)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Water.Neronite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Shark)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Water.Neronite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DukeFishron)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Water.Neronite>(), Main.rand.Next(1, 2));
            }
            
            //Mushroom
            if (npc.type == NPCID.AnomuraFungus)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.FungiBulb)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.MushiLadybug)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.ZombieMushroom)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GlowingSnail)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.TruffleWorm)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }

            //Cavern
            if (npc.type == NPCID.BlackSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.MotherSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BabySlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GiantWormHead)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Skeleton)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CaveBat)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BlueJellyfish)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Salamander)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Crawdad)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GiantShelly)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Tim)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Pinky)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CochinealBeetle)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DiggerHead)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GiantBat)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.AnglerFish)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GreenJellyfish)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SkeletonArcher)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.RuneWizard)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Mouse)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.GoldMouse)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Earth.Ginite>(), Main.rand.Next(1, 2));
            }

            //Hallow
            if (npc.type == NPCID.Pixie)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Unicorn)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.RainbowSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Gastropod)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.LightMummy)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.LightningBug)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            
            //Underground Hallow
            if (npc.type == NPCID.IlluminantSlime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.IlluminantBat)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.ChaosElemental)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.EnchantedSword)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BigMimicHallow)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.PigronHallow)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.DesertGhoulHallow)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ElementalFragments.Light.Fosnite>(), Main.rand.Next(1, 2));
            }

            //Boss
            if (npc.type == NPCID.SkeletronPrime)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ItemTek.Boss.MetalPlate>(), Main.rand.Next(5, 30));
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ItemTek.Boss.MechanicalCore>(), Main.rand.Next(5, 20));
            }
            if (npc.type == NPCID.TheDestroyer)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ItemTek.Boss.MetalPlate>(), Main.rand.Next(5, 30));
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ItemTek.Boss.MechanicalCore>(), Main.rand.Next(5, 20));
            }
            if (npc.type == NPCID.Retinazer)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ItemTek.Boss.MetalPlate>(), Main.rand.Next(5, 30));
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ItemTek.Boss.MechanicalCore>(), Main.rand.Next(5, 20));
            }
            if (npc.type == NPCID.Spazmatism)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ItemTek.Boss.MetalPlate>(), Main.rand.Next(5, 30));
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.ItemTek.Boss.MechanicalCore>(), Main.rand.Next(5, 20));
            }
        }
    }
}
