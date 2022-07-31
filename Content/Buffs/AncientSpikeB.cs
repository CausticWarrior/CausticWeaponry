using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CausticWeaponry.Common;
using CausticWeaponry.Content.Items.Weapons.Minion.AncientSpike;

namespace CausticWeaponry.Content.Buffs
{
    class AncientSpikeB : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Spike");
            Description.SetDefault("A pain in the foot");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            MinionManager modPlayer = player.GetModPlayer<MinionManager>();
            if (player.ownedProjectileCounts[ProjectileType<AncientSpike>()] > 0)
            {
                modPlayer.AncientSpike = true;
            }
            if (!modPlayer.AncientSpike)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}
