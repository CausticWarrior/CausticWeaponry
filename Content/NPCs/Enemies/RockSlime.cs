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
    public class RockSlime : ModNPC
    {

        public override void SetStaticDefaults()
        {
            
            Main.npcFrameCount[NPC.type] = 2;
        }
        public override void SetDefaults()
        {
            NPC.lifeMax = 55;
            NPC.height = 24;
            NPC.width = 32;
            NPC.aiStyle = 1;
            NPC.damage = 15;
            NPC.defense = 6;
            AnimationType = NPCID.BlueSlime;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath2;
            NPC.value = 100;
            NPC.knockBackResist = 0.3f;
           

        }




        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.Player.ZoneOverworldHeight? 0.01f : 0f;
        }
        public override void OnKill()
        {
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.StoneBlock, Main.rand.Next(5, 10));

            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Gel, Main.rand.Next(1, 4));
        }

    }
}