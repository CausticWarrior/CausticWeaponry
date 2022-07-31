using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace CausticWeaponry.Content.Buffs
{
    public class AncientsWrath : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancients Wrath");
            Description.SetDefault("");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = false;
            Main.buffNoSave[Type] = true;
        }



        public override void Update(NPC npc, ref int buffIndex)
        {
            if (npc.lifeRegen > 0)
            {
                npc.lifeRegen = 0;
            }
            npc.lifeRegen -= 2;
        }
    }
}