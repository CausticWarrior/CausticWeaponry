using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace CausticWeaponry.Content.Items.MiscMaterials
{
    internal class AncientCopperShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Copper Shard");
            Tooltip.SetDefault("The shards from an ancient adventurer's weapons and armor long ago");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            Item.value = Item.buyPrice(copper: 25);
            Item.maxStack = 999;
            Item.rare = ItemRarityID.Green;
        }
    }
}
