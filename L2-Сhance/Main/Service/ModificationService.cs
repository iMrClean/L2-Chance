using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class ModificationService
    {
        private int tryCount = 1;

        private ItemFactory itemFactory;

        public ModificationService()
        {
            itemFactory = new ItemFactory();
        }

        public int TryCount
        {
            get { return tryCount; }

            private set { tryCount = value; }
        }

        public event EventHandler<string> LogEvent;

        public event EventHandler<int> EnchanceLevelEvent;

        internal void Processing(Item item)
        {
            bool isSuccessMagic = item.DoMagic();
            // Thank you C#. It's not possible isSuccessMagic ? SuccessMethod : FailureMethod;
            if (isSuccessMagic)
            {
                SuccessMethod(item);
            }
            else
            {
                FailureMethod(item);
            }
        }

        internal void SuccessMethod(Item item)
        {
            item = itemFactory.SaveItem(item);
            UpdateEnchanceLevelEvent(item);
            UpdateLogEvent("[Успешно] Модификация на " + item.EnchanceLevel + " прошла успешно. Количество попыток " + TryCount);
        }

        internal void FailureMethod(Item item)
        {
            ++TryCount;
            item = itemFactory.DeleteItem(item);
            UpdateEnchanceLevelEvent(item);
            UpdateLogEvent("[Неуспешно] Модификация прошла неуспешно. Количество попыток " + TryCount);
        }

        internal void ResetCount()
        {
            TryCount = 1;
        }

        public void UpdateEnchanceLevelEvent(Item item)
        {
            EnchanceLevelEvent?.Invoke(this, item.EnchanceLevel);
        }

        private void UpdateLogEvent(string logMessage)
        {
            LogEvent?.Invoke(this, logMessage);
        }
    }
}
