using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Tiles.ElementalBiomes
{
	public class ThunderDirtTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			drop = ItemType<Items.Thunder.ThunderDirt>();
			AddMapEntry(new Color(20, 10, 50));
		}
	}
}