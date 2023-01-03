using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Factory;
using L2_Сhance.Main.Service;
using L2_Сhance.Main.Util;
using System;

namespace L2_Сhance.Main.Model
{
    internal abstract class ItemFactory
    {
        public int RandomEnchance { get; set; }

        public int EnchantChance { get; set; }

        public int SaveEnchanceLevel { get; }

        public int EnchanceLevel { get; set; }

        public abstract int GetCurrentChance();

        public virtual bool DoMagic()
        {
            RandomEnchance = Randomizer.GenerateRandomValue();

            if (EnchanceLevel < SaveEnchanceLevel)
            {
                return true;
            }

            return RandomEnchance <= EnchantChance;
        }
    }
}
