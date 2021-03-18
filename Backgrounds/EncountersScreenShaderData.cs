﻿using Terraria;
using System;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;

namespace AwakeningMinerals.Backgrounds
{
    public class EncountersScreenShaderData : ScreenShaderData
    {
        //private int voidEventIndex;

        public EncountersScreenShaderData(string passName)
            : base(passName)
        {
        }

        public override void Apply()
        {
            if (AwakeningMinerals.encounterTimer > 0)
            {
                for (int i = 0; i < Main.npc.Length; i++)
                {
                    UseTargetPosition(Main.player[(int)Player.FindClosest(Main.npc[i].position, Main.npc[i].width, Main.npc[i].height)].Center);
                }
            }
            base.Apply();
        }
    }
}