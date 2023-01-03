using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Service;
using L2_Сhance.Main.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Сhance.Main.Model
{
    internal class Accessory : Item //extends
    {
        private const int SAVE_ENCHANCE_LEVEL = 1;

        public int EnchanceLevel { get; set; }

        public int RandomEnchance { get; set; }

        public ItemType ItemType { get; set; }

        public int EnchantChance { get; set; }

        public bool DoMagic()
        {
            RandomEnchance = Randomizer.GenerateRandomValue();

            if (EnchanceLevel < SAVE_ENCHANCE_LEVEL)
            {
                return true;
            }

            return RandomEnchance <= EnchantChance;
        }

        public int GetCurrentChance()
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
