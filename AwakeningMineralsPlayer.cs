using AwakeningMinerals.Buffs;
using AwakeningMinerals.Items;
using AwakeningMinerals.Projectiles;
using AwakeningMinerals.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;
using System.Security.Permissions;
using Terraria.Graphics.Shaders;
using Terraria.GameContent.Events;

namespace AwakeningMinerals
{
	public class AwakeningMineralsPlayer : ModPlayer
	{

		public bool ZoneSnow;
		private const int saveVersion = 0;

		//Pets
		public bool minionName = false;
		public bool AirButterflyPet = false;
		public bool DeathButterflyPet = false;
		public bool EarthButterflyPet = false;
		public bool FireButterflyPet = false;
		public bool IceButterflyPet = false;
		public bool LightButterflyPet = false;
		public bool MarshyButterflyPet = false;
		public bool MoonButterflyPet = false;
		public bool ThunderButterflyPet = false;
		public bool WaterButterflyPet = false;
		public bool AstralButterflyPet = false;
		public bool MoonInvaderPet = false;
		public bool EternalEarthFlamePet = false;
		public bool EternalAirFlamePet = false;
		public bool EternalDeathFlamePet = false;
		public bool EternalFlamePet = false;
		public bool EternalIceFlamePet = false;
		public bool EternalMoonFlamePet = false;
		public bool EternalLightFlamePet = false;
		public bool EternalThunderFlamePet = false;
		public bool EternalWaterFlamePet = false;
		public bool MoonCellPet = false;

		//Debuffs
		public bool AirDebuff = false;

		//Zones
		public bool ZoneAstralMoon;
		public bool ZoneIceBiome;
		public bool ZoneDeathBiome;
		public bool ZoneEarthBiome;
		public bool ZoneAirBiome;
		public bool ZoneWaterBiome;
		public bool ZoneFireBiome;
		public bool ZoneLightBiome;
		public bool ZoneThunderBiome;



		public static bool hasProjectile;

        public override void ResetEffects()
        {
            minionName = false;
			//Pets
			AirButterflyPet = false;
			DeathButterflyPet = false;
			EarthButterflyPet = false;
			FireButterflyPet = false;
			IceButterflyPet = false;
			LightButterflyPet = false;
			MarshyButterflyPet = false;
			MoonButterflyPet = false;
			ThunderButterflyPet = false;
			WaterButterflyPet = false;
			AstralButterflyPet = false;

			MoonInvaderPet = false;

			EternalAirFlamePet = false;
			EternalDeathFlamePet = false;
			EternalEarthFlamePet = false;
			EternalFlamePet = false;
			EternalIceFlamePet = false;
			EternalLightFlamePet = false;
			EternalMoonFlamePet = false;
			EternalThunderFlamePet = false;
			EternalWaterFlamePet = false;

			MoonCellPet = false;

			//Debuffs
			AirDebuff = false;
        }
		public static int[] iceWidth = new int[3];
		public static int[] iceHeight = new int[3];
		public static Texture2D[] backgroundTexture = new Texture2D[3];
		public override void UpdateBiomes() 
		{
			ZoneAstralMoon = (AwakeningMineralsWorld.AstralMoonTiles > 50);
			ZoneAirBiome = (AwakeningMineralsWorld.AirBiomeTiles > 50);
			ZoneDeathBiome = (AwakeningMineralsWorld.DeathBiomeTiles > 50);
			ZoneEarthBiome = (AwakeningMineralsWorld.EarthBiomeTiles > 50);
			ZoneFireBiome = (AwakeningMineralsWorld.FireBiomeTiles > 50);
			ZoneIceBiome = (AwakeningMineralsWorld.IceBiomeTiles > 50);
			ZoneLightBiome = (AwakeningMineralsWorld.LightBiomeTiles > 50);
			ZoneThunderBiome = (AwakeningMineralsWorld.ThunderBiomeTiles > 50);
			ZoneWaterBiome = (AwakeningMineralsWorld.WaterBiomeTiles > 50);
		}
		public override bool CustomBiomesMatch(Player other) {
			AwakeningMineralsPlayer modOther = other.GetModPlayer<AwakeningMineralsPlayer>();
			return ZoneAstralMoon == modOther.ZoneAstralMoon
				&& ZoneAirBiome == modOther.ZoneAirBiome
				&& ZoneDeathBiome == modOther.ZoneDeathBiome
				&& ZoneEarthBiome == modOther.ZoneEarthBiome
				&& ZoneFireBiome == modOther.ZoneFireBiome
				&& ZoneIceBiome == modOther.ZoneIceBiome
				&& ZoneLightBiome == modOther.ZoneLightBiome
				&& ZoneThunderBiome == modOther.ZoneThunderBiome
				&& ZoneWaterBiome == modOther.ZoneWaterBiome;
		}

		public override void CopyCustomBiomesTo(Player other) 
		{
			AwakeningMineralsPlayer modOther = other.GetModPlayer<AwakeningMineralsPlayer>();
			modOther.ZoneAstralMoon = ZoneAstralMoon;
			modOther.ZoneAirBiome = ZoneAirBiome;
			modOther.ZoneDeathBiome = ZoneDeathBiome;
			modOther.ZoneEarthBiome = ZoneEarthBiome;
			modOther.ZoneFireBiome = ZoneFireBiome;
			modOther.ZoneIceBiome = ZoneIceBiome;
			modOther.ZoneLightBiome = ZoneLightBiome;
			modOther.ZoneThunderBiome = ZoneThunderBiome;
			modOther.ZoneWaterBiome = ZoneWaterBiome;
		}

		public override void SendCustomBiomes(BinaryWriter writer) 
		{
			BitsByte flags = new BitsByte();
			flags[0] = ZoneAstralMoon;
			flags[1] = ZoneAirBiome;
			flags[2] = ZoneDeathBiome;
			flags[3] = ZoneEarthBiome;
			flags[4] = ZoneFireBiome;
			flags[5] = ZoneIceBiome;
			flags[6] = ZoneLightBiome;
			flags[7] = ZoneThunderBiome;
			flags[8] = ZoneWaterBiome;

			writer.Write(flags);
		}

		public override void ReceiveCustomBiomes(BinaryReader reader) 
		{
			BitsByte flags = reader.ReadByte();
			ZoneAstralMoon = flags[0];
			ZoneAirBiome = flags[1];
			ZoneDeathBiome = flags[2];
			ZoneEarthBiome = flags[3];
			ZoneFireBiome = flags[4];
			ZoneIceBiome = flags[5];
			ZoneLightBiome = flags[6];
			ZoneThunderBiome = flags[7];
			ZoneWaterBiome = flags[8];
			
			}
	}
}
