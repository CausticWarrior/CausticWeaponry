using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using CausticWeaponry.Content.Projectiles.Weapon;
using CausticWeaponry.Content.Items.MiscMaterials;
using CausticWeaponry.Content.Projectiles;

namespace CausticWeaponry.Content.Items.Weapons.Melee.Sword
{
    internal class AncientCopperShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Rapier;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 12;
            Item.knockBack = 4f;

            Item.rare = ItemRarityID.Green;
            Item.value = Item.buyPrice(silver: 20);

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<AncientCopperShortswordProjectile>();
            Item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(itemID: ModContent.ItemType<AncientCopperShard>(), 8)
                .AddTile(TileID.WorkBenches)
                .Register();

        }
    }
}
