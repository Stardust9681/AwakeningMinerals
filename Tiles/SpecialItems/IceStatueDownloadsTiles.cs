using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;
using AwakeningMinerals.Items;

namespace AwakeningMinerals.Tiles.SpecialItems
{
	public class IceStatueDownloadsTiles : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileObsidianKill[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("1k downloads Ice statue");
			AddMapEntry(new Color(144, 148, 144), name);
			dustType = 11;
			disableSmartCursor = true;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 48, ModContent.ItemType<Items.SpecialItems.IceStatueDownloads>());
		}

				public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			Tile tile = Main.tile[i, j];
			if (tile.frameX == 0) {
				// We can support different light colors for different styles here: switch (tile.frameY / 54)
				r = 0.50f;
				g = 0.90f;
				b = 0.95f;
			}
		}
	}
}