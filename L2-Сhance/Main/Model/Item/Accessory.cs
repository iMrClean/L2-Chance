using L2_Сhance.Main.Enum;

namespace L2_Сhance.Main.Model
{
    internal class Accessory : Item
    {
        protected override int GetSaveEnchangeLevel()
        {
            return 1;
        }

        protected override int GetCurrentChance()
        {
            int result = 100;

            switch (EnchanceLevel)
            {
                case 1:
                    result -= 50;
                    break;
                case 2:
                    result -= 60;
                    break;
                case 3:
                    result -= 70;
                    break;
                case 4:
                    result -= 50;
                    break;
                case 5:
                    result -= 92;
                    break;
            }

            return result;
        }
    }
}
