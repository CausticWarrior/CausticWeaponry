using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CausticWeaponry.Content.Items.Mounts.TwinkleWitchBroom
{
	public class TwinkleWitchBroomMount : ModMount
	{
		//overall stats are meant to provide more top speed than the UFO, at the expense of less control
		//also slightly more speed than 1.4's Witch's Broom
		public override void SetStaticDefaults()
		{
			MountData.spawnDust = DustID.Sandnado;
			MountData.buff = ModContent.BuffType<Buffs.TwinkleWitchBroom_Buff>();
			MountData.flightTimeMax = int.MaxValue;//basically infinite flight
			MountData.fatigueMax = int.MaxValue;//if you run this timer out, you should go outside
			MountData.heightBoost = 0;
			MountData.fallDamage = 0f;//ufo is 0
			MountData.runSpeed = 9.37f;//ufo is 8(this speed value gives a max of 48 mph, compared to the ufo's 41)
			MountData.dashSpeed = 9.37f;//ufo is 8
			MountData.jumpHeight = 5;//ufo is 10
			MountData.acceleration = 0.11f;//ufo is 0.16f(this lower acceleration ensures the ufo still has a purpose)
			MountData.usesHover = true;
			MountData.jumpSpeed = 2f;//ufo is 4
			MountData.blockExtraJumps = true;
			MountData.totalFrames = 2;
			MountData.constantJump = false;
			int[] array = new int[MountData.totalFrames];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 0;
			}
			MountData.playerYOffsets = array;
			MountData.xOffset = 0;
			MountData.bodyFrame = 4;
			MountData.yOffset = 12;
			MountData.playerHeadOffset = 18;
			MountData.standingFrameCount = 2;
			MountData.standingFrameDelay = 15;
			MountData.standingFrameStart = 0;
			MountData.runningFrameCount = 2;
			MountData.runningFrameDelay = 15;
			MountData.runningFrameStart = 0;
			MountData.flyingFrameCount = 2;
			MountData.flyingFrameDelay = 15;
			MountData.flyingFrameStart = 0;
			MountData.inAirFrameCount = 2;
			MountData.inAirFrameDelay = 15;
			MountData.inAirFrameStart = 0;
			MountData.idleFrameCount = 2;
			MountData.idleFrameDelay = 15;
			MountData.idleFrameStart = 0;
			MountData.idleFrameLoop = true;
			MountData.swimFrameCount = MountData.flyingFrameCount;
			MountData.swimFrameDelay = MountData.flyingFrameDelay;
			MountData.swimFrameStart = MountData.flyingFrameStart;
			if (Main.netMode == NetmodeID.Server)
			{
				return;
			}
		
			

		}
		public override void UpdateEffects(Player player)
		{

			// This code spawns some dust if we are moving fast enough.
			if (!(Math.Abs(player.velocity.X) > 7.5f))
			{
				return;
			}
			Rectangle rect = player.getRect();
			Dust.NewDust(new Vector2(rect.X, rect.Y + 18), rect.Width, rect.Height - 18, DustID.Sandnado);
		}
	}
}