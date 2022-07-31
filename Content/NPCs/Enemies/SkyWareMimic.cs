using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using System;


namespace CausticWeaponry.Content.NPCs.Enemies
{
    public class SkyWareMimic : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skyware Mimic");

        }

        public override void SetDefaults()
        {
            
            NPC.width = 42;
            NPC.height = 48;
            NPC.damage = 90;
            NPC.defense = 34;
            NPC.value = 30000;
            NPC.lifeMax = 3500;
            NPC.aiStyle = 87;
            NPC.knockBackResist = 0.1f;
            NPC.HitSound = SoundID.NPCHit4;
            NPC.DeathSound = SoundID.NPCDeath3;
            Main.npcFrameCount[NPC.type] = 14;

            AnimationType = NPCID.BigMimicCrimson;



        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {

            return (spawnInfo.Player.ZoneSkyHeight && Main.hardMode) ? 0.01f : 0f;


        }
        public override void OnKill()
        {
            int rand = Main.rand.Next(1, 4);
            int rand2 = Main.rand.Next(1, 3);
            if (rand == 1)
            {
                Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.ShinyRedBalloon);
            }
            else if (rand == 2)
            {
                Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Starfury);
            }
            else
            {
                Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.LuckyHorseshoe);
            }




            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.GreaterHealingPotion, Main.rand.Next(5, 11));






        }

    }
}