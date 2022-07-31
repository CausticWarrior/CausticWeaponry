using Terraria;
using Terraria.ModLoader;

namespace CausticWeaponry.Content.Dusts
{
    public class RhuthiniumDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = false;
            dust.noLight = true;
            dust.scale = 1f;
        }
    }
}