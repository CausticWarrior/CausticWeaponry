using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using CausticWeaponry.Content.Items.Weapons;
using CausticWeaponry.Content.Items.MiscMaterials;

namespace CausticWeaponry.Content.Items.Weapons.Melee.Cutlasses
{
    internal class AncientCopperCutlass : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Copper Cutlass");
            Tooltip.SetDefault("Finally, the ancient adventurer's weapon is mended! Even after all this time it is sharp");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {

            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 13;
            Item.useAnimation = 13;
            Item.autoReuse = true;

        
            Item.DamageType = DamageClass.Melee;
            Item.damage = 24;
            Item.knockBack = 3.5f;
            Item.crit = 12;

            Item.value = Item.buyPrice(silver: 90, copper: 80);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(itemID: ModContent.ItemType<AncientCopperShard>(), 14)
                .AddTile(TileID.WorkBenches)
                .Register();

        }

    }
}