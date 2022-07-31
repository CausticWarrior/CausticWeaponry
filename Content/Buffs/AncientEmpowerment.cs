using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CausticWeaponry.Content.Buffs
{
    internal class AncientEmpowerment : ModBuff
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Empowerment");
            Description.SetDefault("Slight improvement to regen, jump height, and speed");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 2;
            player.moveSpeed += 0.75f;
            player.statDefense += 2;
            player.jumpSpeedBoost += 4;
        }
    }
}
