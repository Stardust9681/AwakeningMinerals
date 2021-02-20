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
using Microsoft.Xna.Framework.Graphics;
using Terraria.Enums;
using Terraria.Localization;
using AwakeningMinerals.Buffs;

namespace AwakeningMinerals.Tiles.SpecialItems
{
	public class GoldenStatueDownloadsTiles : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileLighted[Type] = true;	
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            //TileObjectData.newTile.CoordinateHeights = new int[]{16};
            TileObjectData.addTile(Type);
            //animationFrameHeight = 54;
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
            AddMapEntry(new Color(169, 169, 169));
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 48, ModContent.ItemType<Items.SpecialItems.GoldenStatueDownloads>());
		}

				public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			Tile tile = Main.tile[i, j];
			if (tile.frameX == 0) {
				// We can support different light colors for different styles here: switch (tile.frameY / 54)
				r = 0.70f;
				g = 0.65f;
				b = 0.35f;
			}
		}
		 public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.player[Main.myPlayer];
                int style = Main.tile[i, j].frameX / 100;
                player.AddBuff(mod.BuffType("GoldenStatueDownloadsBuff"), 1000, true);
				
            }
        }
	}
}