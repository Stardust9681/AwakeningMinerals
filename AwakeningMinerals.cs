using AwakeningMinerals.Tiles;
using AwakeningMinerals.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;
using System.Linq;

namespace AwakeningMinerals
{
	public class AwakeningMinerals : Mod
	{
		public AwakeningMinerals()
		{
			Properties = new ModProperties
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		public static void Log(object message)
		{

		}

		internal static AwakeningMinerals instance;
        public static int encounterTimer = 0;

        public override void Load()
        {

        }
		public override void PostSetupContent()
		{
			Mod bossChecklist = ModLoader.GetMod("BossChecklist");
			if (bossChecklist != null)
			{
				//SlimeKing = 1f;
				//EyeOfCthulhu = 2f;
				//EaterOfWorlds = 3f;
				//QueenBee = 4f;
				//Skeletron = 5f;
				//WallOfFlesh = 6f;
				//TheTwins = 7f;
				//TheDestroyer = 8f;
				//SkeletronPrime = 9f;
				//Plantera = 10f;
				//Golem = 11f;
				//DukeFishron = 12f;
				//LunaticCultist = 13f;
				//Moonlord = 14f;
            }
        }

        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)
            {
                return;
            }
            // Make sure your logic here goes from lowest priority to highest so your intended priority is maintained.
            if (Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>().ZoneAstralMoon)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/AstralBiomeMusic");
                priority = MusicPriority.BiomeHigh;
            }if (Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>().ZoneAirBiome)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/ElementalBiomes");
                priority = MusicPriority.BiomeHigh;
            }
			if (Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>().ZoneDeathBiome)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/ElementalBiomes");
                priority = MusicPriority.BiomeHigh;
            }
			if (Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>().ZoneEarthBiome)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/ElementalBiomes");
                priority = MusicPriority.BiomeHigh;
            }
			if (Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>().ZoneFireBiome)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/ElementalBiomes");
                priority = MusicPriority.BiomeHigh;
            }
			if (Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>().ZoneIceBiome)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/ElementalBiomes");
                priority = MusicPriority.BiomeHigh;
            }
			if (Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>().ZoneLightBiome)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/ElementalBiomes");
                priority = MusicPriority.BiomeHigh;
            }
			if (Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>().ZoneThunderBiome)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/ElementalBiomes");
                priority = MusicPriority.BiomeHigh;
            }
			if (Main.LocalPlayer.GetModPlayer<AwakeningMineralsPlayer>().ZoneWaterBiome)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/ElementalBiomes");
                priority = MusicPriority.BiomeHigh;
            }
        }
	}
}