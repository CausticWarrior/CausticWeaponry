using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace CausticWeaponry.Content.NPCs.Enemies
{
    public class AmberSlime : ModNPC
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
            NPC.damage = 18;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath2;
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
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Amber, Main.rand.Next(3, 8));
        }

    }
}
