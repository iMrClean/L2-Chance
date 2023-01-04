﻿using L2_Сhance.Main.Enum;

namespace L2_Сhance.Main.Model
{
    internal class Accessory : Item
    {
        protected override int GetSaveEnchangeLevel()
        {
            return 1;
        }

        public override int GetCurrentChance()
        {
            int result = 100;

            if (EnchanceLevel == 1)
            {
                result -= 50;
            }
            else if (EnchanceLevel == 2)
            {
                result -= 60;
            }
            else if (EnchanceLevel == 3)
            {
                result -= 70;
            }
            else if (EnchanceLevel == 4)
            {
                result -= 50;
            }
            else if (EnchanceLevel == 5)
            {
                result -= 92;
            }

            return result;
        }
    }
}
