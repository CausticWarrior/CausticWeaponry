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
    public class AmethystSlime : ModNPC
    {

        public override void SetStaticDefaults()
        {

            Main.npcFrameCount[NPC.type] = 2;
        }
        public override void SetDefaults()
        {
            NPC.lifeMax = 75;
            NPC.height = 30;
            NPC.width = 36;
            NPC.aiStyle = 1;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath2;
            NPC.damage = 18;
            NPC.defense = 8;
            AnimationType = NPCID.BlueSlime;
            NPC.value = 200;
            NPC.knockBackResist = 0.3f;

        }




        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.Player.ZoneRockLayerHeight ? 0.1f : 0f;
        }
        public override void OnKill()
        {
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Amethyst, Main.rand.Next(3, 8));
        }

    }
}