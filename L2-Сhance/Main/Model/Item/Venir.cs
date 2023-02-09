namespace L2_Сhance.Main.Model.Item
{
    internal class Venir : AbstractItem
    {
        public override int GetSaveEnchangeLevel()
        {
            return 1;
        }

        public override int GetCurrentChance()
        {
            int result = 100;

            switch (EnchanceLevel)
            {
                case 1:
                    result -= 50;
                    break;
                case 2:
                    result -= 55;
                    break;
                case 3:
                    result -= 60;
                    break;
                case 4:
                    result -= 65;
                    break;
                case 5:
                    result -= 50;
                    break;
            }

            return result;
        }
    }
}
