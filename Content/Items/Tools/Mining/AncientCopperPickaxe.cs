
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using CausticWeaponry.Content.Items.MiscMaterials;

namespace CausticWeaponry.Content.Items.Tools.Mining
{
    internal class AncientCopperPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 11;
            Item.useAnimation = 11;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 14;
            Item.knockBack = 3f;

            Item.value = Item.buyPrice(silver: 42);
            Item.rare = ItemRarityID.Green;

            Item.pick = 60;
        }
        public override void AddRecipes()
        {
            _ = CreateRecipe()
                .AddIngredient(itemID: ModContent.ItemType<AncientCopperShard>(), 10)
                .Register();

        }

    }
}
