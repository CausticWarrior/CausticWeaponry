using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace CausticWeaponry.Content.Items.Mounts.TwinkleWitchBroom
{
    public class TwinkleWitchBroom : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Twinkle Witch's Broom");
            Tooltip.SetDefault("'Don't even think about flying. And then, pretty soon, you'll be flying again.'");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 30;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.noUseGraphic = true;
            Item.value = Item.sellPrice(0, 5);
            Item.rare = ItemRarityID.Yellow;
            Item.UseSound = SoundID.Item25;
            Item.noMelee = true;
            Item.mountType = ModContent.MountType<TwinkleWitchBroomMount>();
        }

    }
}
