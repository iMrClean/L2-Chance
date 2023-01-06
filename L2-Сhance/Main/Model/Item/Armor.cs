using L2_Сhance.Main.Enum;

namespace L2_Сhance.Main.Model
{
    internal class Armor : Item
    {
        protected override int GetSaveEnchangeLevel()
        {
            return 4;
        }

        protected override int GetCurrentChance()
        {
            int result = 100;

            switch (EnchanceLevel)
            {
                case 4:
                    result -= 70;
                    break;
                case 5:
                    result -= 75;
                    break;
                case 6:
                    result -= 80;
                    break;
                case 7:
                    result -= 85;
                    break;
                case 8:
                    result -= 90;
                    break;
                case 9:
                    result -= 95;
                    break;
            }

            return result;
        }
    }
}
