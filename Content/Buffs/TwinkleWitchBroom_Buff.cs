using Terraria;
using Terraria.ModLoader;

namespace CausticWeaponry.Content.Buffs
{
	public class TwinkleWitchBroom_Buff : ModBuff
	{
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Twinkle Witch's Broom");
			Description.SetDefault("So I'm gonna fly!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		
    }
}
	

