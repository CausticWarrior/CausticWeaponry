using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using CausticWeaponry.Content.Projectiles;
using CausticWeaponry.Content.Items;
using CausticWeaponry.Content.Items.MiscMaterials;
using CausticWeaponry.Content.Projectiles.Weapon;

namespace CausticWeaponry.Content.Items.Weapons.Ranged
{
    internal class AncientCopperBow : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Copper Bow");
            Tooltip.SetDefault("It only shoots wooden arrows. Does not consume ammo");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {

            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.autoReuse = true;
            Item.ammo = AmmoID.Arrow;
            Item.shootSpeed = 40;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
           


            Item.DamageType = DamageClass.Ranged;
            Item.damage = 20;
            Item.knockBack = 3.5f;
            Item.crit = 11;

            Item.value = Item.buyPrice(silver: 40, copper: 30);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item5;
			Item.noMelee = true;
            Item.value = Item.buyPrice(silver: 50, copper: 23);

        }
		public override Vector2? HoldoutOffset()
		{
			Vector2 offset = new(6, 0);
			return offset;
		}

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(itemID: ModContent.ItemType<AncientCopperShard>(), 12)
                .AddTile(TileID.WorkBenches)
                .Register();

        }

    }



}