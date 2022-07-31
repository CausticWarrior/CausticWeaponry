using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using CausticWeaponry.Content.Projectiles.Weapon;
using CausticWeaponry.Content.Items.MiscMaterials;

namespace CausticWeaponry.Content.Items.Weapons.Magic.Wands
{
    internal class AncientWand : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.useStyle = ItemUseStyleID.HoldUp;

            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.mana = 8;
            Item.damage = 24;
            Item.knockBack = 3.2f;

            Item.useTime = 20;
            Item.useAnimation = 15;

            Item.UseSound = SoundID.Item71;

            Item.shoot = ModContent.ProjectileType<AncientWandP>();
            Item.shootSpeed = 1f;
            Item.rare = ItemRarityID.Green;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(itemID: ModContent.ItemType<AncientCopperShard>(), 15)
                .AddTile(TileID.WorkBenches)
                .Register();

        }
    }
}
