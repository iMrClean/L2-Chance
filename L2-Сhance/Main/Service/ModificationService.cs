using L2_Сhance.Main.Model;
using L2_Сhance.Main.Util;
using System;

namespace L2_Сhance.Main.Service
{
    internal class ModificationService
    {

        internal void DoMagic(object item)
        {
            if (item is Accessory)
            {
                bool result = DoMagic((Accessory)item);
                Console.WriteLine(result);
            }
            if (item is Weapon)
            {
                bool result = DoMagic((Weapon)item);
                Console.WriteLine(result);
            }
            if (item is Armor)
            {
                bool result = DoMagic((Armor)item);
                Console.WriteLine(result);
            }
        }

        internal bool DoMagic(Accessory accessory)
        {
            int randomEnchance = Randomizer.GenerateRandomValue();

            if (accessory.EnchanceLevel < accessory.SaveEnchanceLevel)
            {
                return true;
            }

            return randomEnchance <= accessory.EnchantChance;
        }

        internal bool DoMagic(Weapon weapon)
        {
            int randomEnchance = Randomizer.GenerateRandomValue();

            if (weapon.EnchanceLevel < weapon.SaveEnchanceLevel)
            {
                return true;
            }

            return randomEnchance <= weapon.EnchantChance;
        }

        internal bool DoMagic(Armor armor)
        {
            int randomEnchance = Randomizer.GenerateRandomValue();

            if (armor.EnchanceLevel < armor.SaveEnchanceLevel)
            {
                return true;
            }

            return randomEnchance <= armor.EnchantChance;
        }
    }
}
