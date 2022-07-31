using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace CausticWeaponry.Common
{
    public class MinionManager : ModPlayer
    {

        public bool AncientSpike = false;


        public float mythrilPrismRotation = 0;

        public override void ResetEffects()
        {

            AncientSpike = false;

        }

        public override void PreUpdate()
        {
            mythrilPrismRotation += (float)Math.PI / 90f;
     
        }
    }
}
