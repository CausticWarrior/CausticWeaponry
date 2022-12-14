using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CausticWeaponry.Content.Dusts
{
    public class PursuitRuneDeath : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.noLight = false;
            dust.scale = 1f;
        }
        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return Color.White;
        }
    }
}