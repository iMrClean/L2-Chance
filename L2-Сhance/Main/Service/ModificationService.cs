using L2_Сhance.Main.Model;
using System;

namespace L2_Сhance.Main.Service
{
    internal class ModificationService
    {
        private int itemCount = 1;
        public int ItemCount
        {
            get { return itemCount; }

            private set { itemCount = value; }
        }

        public event EventHandler<string> LogEvent;

        public event EventHandler<int> EnchanceLevelEvent;

        internal void Processing(Item item)
        {
            bool isSuccessMagic = item.DoMagic();
            // Thank you C# No. It' not possible isSuccessMagic ? SuccessMethod : FailureMethod;
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
            //TODO тут нужно сохранить это в БД и из сохраненного итема вытащить EnchanceLevel
            UpdateLogEvent("[Успешно] Модификация на " + ++item.EnchanceLevel + " прошла успешно. Количество попыток " + ItemCount);
        }

        internal void FailureMethod(Item item)
        {
            ++ItemCount;
            //TODO тут нужно сохранить это в БД и из сохраненного итема вытащить EnchanceLevel
            UpdateLogEvent("[Неуспешно] Модификация на " + ++item.EnchanceLevel + " прошла неуспешно. Количество попыток " + ItemCount);
        }

        internal void ResetCount()
        {
            ItemCount = 1;
        }

        private void UpdateLogEvent(string logMessage)
        {
            LogEvent?.Invoke(this, logMessage);
        }

        public void UpdateEnchanceLevelEvent(Item item)
        {
            EnchanceLevelEvent?.Invoke(this, item.EnchanceLevel);
        }
    }
}
