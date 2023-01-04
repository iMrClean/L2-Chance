using L2_Сhance.Main.Enum;

namespace L2_Сhance.Main.Model
{
    internal class Weapon : Item
    {
        protected override int GetSaveEnchangeLevel()
        {
            return 4;
        }

        public override int GetCurrentChance()
        {
            int result = 100;

            if (EnchanceLevel == 4)
            {
                result -= 70;
            }
            else if (EnchanceLevel == 5)
            {
                result -= 75;
            }
            else if (EnchanceLevel == 6)
            {
                result -= 80;
            }
            else if (EnchanceLevel == 7)
            {
                result -= 85;
            }
            else if (EnchanceLevel == 8)
            {
                result -= 90;
            }
            else if (EnchanceLevel == 9)
            {
                result -= 95;
            }

            return result;
        }
    }
}
