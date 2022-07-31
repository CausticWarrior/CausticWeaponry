using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using CausticWeaponry.Content.Items;

namespace CausticWeaponry.Content.Items.Consumables.Potions
{
    internal class HealthVial : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vial of Health");
            Tooltip.SetDefault("Restores 35 life");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 30;
        }

        public override void SetDefaults()
        {

            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.autoReuse = true;
            Item.potion = true;
            Item.consumable = true;
            Item.healLife = 35;

        
            

            Item.value = Item.buyPrice(copper: 80);
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item3;
            Item.maxStack = 30;
        }
        public override void AddRecipes()
        {
            _ = CreateRecipe()
                .AddIngredient(ItemID.Gel, 10)
                .AddIngredient(ItemID.Mushroom, 5)
                .AddTile(TileID.Bottles)
                .Register();

        }



    }
}