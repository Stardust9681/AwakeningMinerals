using AwakeningMinerals.Tiles.ElementalBiomes.Trees;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Tiles.ElementalBiomes
{
	public class AirWoodTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			drop = ItemType<Items.Air.AirWood>();
			AddMapEntry(new Color(80, 175, 210));
			SetModTree(new AirTree());
		}
	}
}