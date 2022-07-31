using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CausticWeaponry.Content.Buffs;
using CausticWeaponry.Content.Items.MiscMaterials;

namespace CausticWeaponry.Content.Items.Weapons.Minion.AncientSpike
{
    internal class AncientSpikeStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Spike Staff");
            Tooltip.SetDefault("Summons a damaging spike. Will reposition if you move away");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            ItemID.Sets.GamepadWholeScreenUseRange[Item.type] = true; // This lets the player target anywhere on the whole screen while using a controller
            ItemID.Sets.LockOnIgnoresCollision[Item.type] = true;
        }


        public override void SetDefaults()
        {
            Item.damage = 12;
            Item.mana = 20;
            Item.width = 38;
            Item.height = 38;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.noMelee = true;
            Item.knockBack = 0f;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item44;
            Item.autoReuse = true;
            Item.shoot = ProjectileType<AncientSpike>();
            Item.DamageType = DamageClass.Summon;
            Item.buffType = BuffType<AncientSpikeB>();
            Item.buffTime = 3600;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            player.SpawnMinionOnCursor(source, player.whoAmI, type, Item.damage, knockback);
            return false;
        }
        public override void AddRecipes()
        {
            _ = CreateRecipe()
                .AddIngredient(itemID: ModContent.ItemType<AncientCopperShard>(), 12)
                .AddIngredient(ItemID.Stinger, 2)
                .AddTile(TileID.WorkBenches)
                .Register();

        }


    }

}
