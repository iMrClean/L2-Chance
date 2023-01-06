using L2_Сhance.Main.Model;
using L2_Сhance.Main.Service.Item;
using L2_Сhance.Main.Util;
using System;

namespace L2_Сhance.Main.Service
{
    internal abstract class AbstractService<T> : IAbstractService where T : AbstractItem
    {
        public int TryCount { get; private set; } = 1;

        public abstract T GetItem();

        public abstract T SaveItem(T item);

        public abstract T DeleteItem();

        AbstractItem IAbstractService.GetItem()
        {
            return GetItem();
        }

        public AbstractItem SaveItem(AbstractItem item)
        {
            return SaveItem((T)item);
        }

        AbstractItem IAbstractService.DeleteItem()
        {
            return DeleteItem();
        }

        public bool DoMagic(AbstractItem item)
        {
            return DoMagic((T)item);
        }

        public virtual bool DoMagic(T item)
        {
            int randomEnchance = Randomizer.GenerateRandomValue();

            if (item.EnchanceLevel < item.GetSaveEnchangeLevel())
            {
                return true;
            }

            return randomEnchance <= item.GetCurrentChance();
        }
    }
}
