using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.Modules;
using Terraria.ID;
using Microsoft.Xna.Framework;


namespace CausticWeaponry.Content.NPCs.Enemies
{
    public class HellstoneSlime : ModNPC
    {

        public override void SetStaticDefaults()
        {

            Main.npcFrameCount[NPC.type] = 2;
        }
        public override void SetDefaults()
        {
            NPC.lifeMax = 350;
            NPC.height = 30;
            NPC.width = 36;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath2;
            NPC.aiStyle = 1;
            NPC.damage = 45;
            NPC.defense = 22;
            AnimationType = NPCID.BlueSlime;
            NPC.value = 10000;
            NPC.lavaImmune = true;
            NPC.knockBackResist = 0.1f;


        }
        public override void AI()
        {
            int Dustid = Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Lava, 0, 0, 120, default(Color), 1f);
            Main.dust[Dustid].noGravity = true;
        }




        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {

            return spawnInfo.Player.ZoneUnderworldHeight ? 0.1f : 0f;


        }
        public override void OnKill()
        {
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Obsidian, Main.rand.Next(5, 20));
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Hellstone, Main.rand.Next(5, 20));

        }

    }
}