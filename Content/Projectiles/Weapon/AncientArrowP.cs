using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using CausticWeaponry.Content.Items.Weapons;

namespace CausticWeaponry.Content.Projectiles.Weapon
{
    public class AncientArrowP : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Arrow");
        }

        public override void SetDefaults()
        {
            Projectile.width = 24;
            Projectile.height = 24;

            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.tileCollide = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.ownerHitCheck = true;
            Projectile.extraUpdates = 1;
            Projectile.timeLeft = 300;

            Projectile.aiStyle = ProjAIStyleID.Arrow;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.penetrate--;
            Vector2 targetPos;
            targetPos.X = Main.MouseWorld.X;
            targetPos.Y = Main.MouseWorld.Y;
            Projectile.velocity = Projectile.DirectionTo(targetPos) * 22f;

            return false;
        }


        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Vector2 targetPos;
            targetPos.X = Main.MouseWorld.X;
            targetPos.Y = Main.MouseWorld.Y;
            Projectile.velocity = Projectile.DirectionTo(targetPos) * 22f;
        }
    }
}

