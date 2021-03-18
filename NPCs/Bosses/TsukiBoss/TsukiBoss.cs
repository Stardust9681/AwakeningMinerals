using Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using AwakeningMinerals.Items;
using System.Collections.Specialized;

namespace AwakeningMinerals.NPCs.Bosses.TsukiBoss
{
    [AutoloadBossHead]
    public class TsukiBoss : ModNPC
    {
        private Player player;
        private float speed;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tsuki - The moon light");

        }

        public override void SetDefaults()
        {
            npc.aiStyle = 5;
            npc.lifeMax = 2500;
            npc.damage = 5;
            npc.defense = 10;
            npc.knockBackResist = 0f;
            npc.width = 162;
            npc.height = 150;
            npc.value = Item.buyPrice(0, 15, 00, 00);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = false;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/HitTsukiBoss");
            npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCDeath/DeathTsukiBoss");
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/TsukiBoss");
            bossBag = mod.ItemType("TsukiBossBag");
            npc.netAlways = true;
            Main.npcFrameCount[npc.type] = 4;

        }

        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/TsukiBossGore1"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/TsukiBossGore2"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/TsukiBossGore3"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/TsukiBossGore4"), 1f);
            }
        }

        public override bool PreNPCLoot()
        {
            return true;
        }

        public override void NPCLoot()
        {
            if (Main.expertMode)
            {
                npc.DropBossBags();
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Crystal"), Main.rand.Next(1, 10));
            }
            else
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Crystal"), Main.rand.Next(1, 5));

                int choice = Main.rand.Next(2);
                if (choice == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TsukiSword"), 1);
                }
                if (choice == 1)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TsukiSpear"), 1);
                }
                //if (choice == 2)
                //{
                    //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TsukiStaff"), 1);
                //}
                //if (choice == 3)
                //{
                    //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TsukiBow"), 1);
                //}
            }

        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.5f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.5f);
        }

        public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;

            npc.ai[1]++;
            if (npc.ai[1] >= 230)  // 230 is projectile fire rate
            {
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 20;  //projectile damage
                int type = mod.ProjectileType("CrystalFragmentProj");  //put your projectile
                Main.PlaySound(SoundID.Item28.SoundId, (int)npc.position.X, (int)npc.position.Y, SoundID.Item28.Style);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
            }
            npc.ai[1]++;
            //if (npc.ai[0] % 600 == 3)  //Npc spown rate

            //{
            //NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("IceBossMinion"));  //NPC name
            //}
            //npc.ai[1] += 0;
            //if (npc.life <= 2750)  //when the boss has less than 70 health he will do the charge attack
            //    npc.ai[2]++;                //Charge Attack
            //if (npc.ai[2] >= 70)
            //{
            //    npc.damage = 15;
            //    npc.defense = 15;
            //    npc.velocity.X += 0.20f;
            //    npc.velocity.Y += 0.20f;
            //    Vector2 vector8 = new Vector2(npc.position.X + (npc.width * 0.5f), npc.position.Y + (npc.height * 0.5f));
            //    {
            //        float rotation = (float)Math.Atan2((vector8.Y) - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), (vector8.X) - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
            //        npc.velocity.X = (float)(Math.Cos(rotation) * 12) * -1;
            //        npc.velocity.Y = (float)(Math.Sin(rotation) * 12) * -1;
            //   }
            //    //Dust
            //    npc.ai[0] %= (float)Math.PI * 2f;
            //    Vector2 offset = new Vector2((float)Math.Cos(npc.ai[0]), (float)Math.Sin(npc.ai[0]));
            //    Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 20);
            //    npc.ai[2] = -300;
            //    Color color = new Color();
            //    Rectangle rectangle = new Rectangle((int)npc.position.X, (int)(npc.position.Y + ((npc.height - npc.width) / 2)), npc.width, npc.width);
            //    int count = 30;
            //   for (int i = 1; i <= count; i++)
            //    {
            //        int dust = Dust.NewDust(npc.position, rectangle.Width, rectangle.Height, 6, 0, 0, 100, color, 2.5f);
            //        Main.dust[dust].noGravity = false;
            //    }
            //   return;
            //}
        }
        //Boss second stage texture
        private const int Sphere = 50;

        public override bool PreDraw(SpriteBatch spriteBatch, Color drawColor)

        {
            if (npc.life <= 1750)
            {
                npc.ai[0]++;
                Player P = Main.player[npc.target];
                if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
                {
                    npc.TargetClosest(true);
                }
                npc.netUpdate = true;

                if (npc.life <= 2200)
                {
                    npc.damage = 5;
                    npc.defense = 5;

                    npc.ai[1]++;
                    if (npc.ai[1] >= 200)  // 230 is projectile fire rate
                    {
                        float Speed = 20f;  //projectile speed
                        Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                        int damage = 30;  //projectile damage
                        int type = mod.ProjectileType("CrystalBallProj");  //put your projectile
                        Main.PlaySound(SoundID.Item28.SoundId, (int)npc.position.X, (int)npc.position.Y, SoundID.Item28.Style);
                        float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                        int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);

                    }

                    if (npc.life <= 750)
                    {
                        npc.defense = 5;

                        npc.ai[1]++;
                        if (npc.ai[1] >= 210)  // 230 is projectile fire rate
                        {
                            float Speed = 15f;  //projectile speed
                            Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                            int damage = 30;  //projectile damage
                            int type = mod.ProjectileType("IceBossBlizzardBallProjectile");  //put your projectile
                            Main.PlaySound(SoundID.Item28.SoundId, (int)npc.position.X, (int)npc.position.Y, SoundID.Item28.Style);
                            float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                            int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                        }
                    }

                    if (npc.life <= 500)
                    {
                        npc.defense = 10;
                    }

                }
            }
            return true;
        }

        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return null;
        }
        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 0.15000000596046448;
            npc.frameCounter %= (double)Main.npcFrameCount[npc.type];
            int num = (int)npc.frameCounter;
            npc.frame.Y = num * frameHeight;

            //harpy rotation
            npc.rotation = npc.velocity.X * 0.05f;
        }
    }
}