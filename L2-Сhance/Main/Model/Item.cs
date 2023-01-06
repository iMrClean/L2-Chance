using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Service;
using L2_Сhance.Main.Util;

namespace L2_Сhance.Main.Model
{
    internal abstract class Item
    {

        public int EnchanceLevel { get; set; }

        public ItemType ItemType { get; set; }

        public virtual bool DoMagic()
        {
            int randomEnchance = Randomizer.GenerateRandomValue();

            if (EnchanceLevel < GetSaveEnchangeLevel())
            {
                return true;
            }

            return randomEnchance <= GetCurrentChance();
        }

        protected abstract int GetSaveEnchangeLevel();

        protected abstract int GetCurrentChance();

    }
}
