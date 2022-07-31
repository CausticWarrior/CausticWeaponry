
using CausticWeaponry.Content.Items.MiscMaterials;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using CausticWeaponry.Content.Projectiles;
using CausticWeaponry.Content.Projectiles.Weapon;

namespace CausticWeaponry.Content.Items.Consumables.Ammo.Arrows
{
    public class AncientArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Redirects itself on collision with an entity");
		}

		public override void SetDefaults()
		{
			Item.damage = 9;
            Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.knockBack = 4f;
			Item.value = 10;
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<AncientArrowP>();
			Item.shootSpeed = 14f;
			Item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			_ = CreateRecipe()
				.AddIngredient(itemID: ModContent.ItemType<AncientCopperShard>(), 1)
				.AddIngredient(ItemID.Gel, 2)
				.AddTile(TileID.WorkBenches)
                .Register();

		}


	}
}
