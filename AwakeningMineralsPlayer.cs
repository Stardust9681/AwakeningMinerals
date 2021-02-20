using AwakeningMinerals.Buffs;
using AwakeningMinerals.Items;
using AwakeningMinerals.Projectiles;
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

namespace AwakeningMinerals
{
	public class AwakeningMineralsPlayer : ModPlayer
	{
		private const int saveVersion = 0;
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

		public static bool hasProjectile;

        public override void ResetEffects()
        {
            minionName = false;

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
        }
	}
}
