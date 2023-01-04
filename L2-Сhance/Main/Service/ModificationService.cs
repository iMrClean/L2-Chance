using L2_Сhance.Main.Model;
using System;

namespace L2_Сhance.Main.Service
{
    internal class ModificationService
    {
        public int ItemCount { get; private set; }

        public event EventHandler<string> LogEvent;

        public event EventHandler<int> EnchanceLevelEvent;

        internal void Processing(Item item)
        {
            bool isSuccessMagic = item.DoMagic();
            // Thank you C# No. It' not possible isSuccessMagic ? SuccessMethod : FailureMethod;
            if (isSuccessMagic)
            {
                SuccessMethod(isSuccessMagic);
            }
            else
            {
                FailureMethod(isSuccessMagic);
            }
        }

        internal void SuccessMethod(bool isSuccessMagic)
        {
            Console.WriteLine("[Успешно] Количество попыток " + ItemCount + " " + isSuccessMagic);
        }

        internal void FailureMethod(bool isSuccessMagic)
        {
            ++ItemCount;
            Console.WriteLine("[Неуспешно] Количество попыток " + ItemCount + " " + isSuccessMagic);
        }

        internal void ResetCount()
        {
            ItemCount = 0;
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
