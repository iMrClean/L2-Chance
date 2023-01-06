using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Service;
using L2_Сhance.Main.Util;

namespace L2_Сhance.Main.Model
{
    internal abstract class Item
    {
        public int EnchantChance { get; set; }

        public int EnchanceLevel { get; set; }

        public ItemType ItemType { get; set; }

        public virtual bool DoMagic()
        {
            int randomEnchance = Randomizer.GenerateRandomValue();

            if (EnchanceLevel < GetSaveEnchangeLevel())
            {
                return true;
            }

            return randomEnchance <= EnchantChance;
        }

        protected abstract int GetSaveEnchangeLevel();
        //ИМХО это тоже должно быть protected но, это используется в репозитории.
        //Думаю стоит либо вынести это в утилити, либо придумать как быть.
        //Должен ли объект иметь свойство шанса заточки???, если мы его можем высчитывать в зависимости от типа
        //В готовом методе (думаю это что-то аналог GenerateRandomValue())
        public abstract int GetCurrentChance();
    }
}
