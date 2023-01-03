using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;
using System.Windows.Forms;

namespace L2_Сhance.Main.Service
{
    internal class ModificationService
    {
        private static readonly Random random = new Random();

        private readonly AccessoryRepository itemRepository;

        public event EventHandler<string> LogEvent;

        public event EventHandler<int> EnchanceLevel;

        public int ItemCount { get; private set; }
        
        public ModificationService()
        {
            itemRepository = new AccessoryRepository();
        }

        internal Item GetItemAccessory()
        {
            return itemRepository.GetItemAccessory();
        }

        internal void DoMagicAccessory(Item item)
        {
            bool enchanceSuccess = item.DoMagic();
            int currentEnchanceLevel = item.EnchanceLevel;
            int resultValue = item.RandomEnchance;

            if (enchanceSuccess) 
            {
                SaveItemAccessory(item);
                string logMessage = $"[Успешно] Текущее значение модификации: {currentEnchanceLevel}, модифицировано: {++currentEnchanceLevel}";
                UpdateLogEvent(logMessage);
                return;
            } else
            {
                ++ItemCount;
                RemoveItemAccessory(item);
                string logMessage = $"[Неуспешно] Шанс: {resultValue}, шанс заточки: {item.EnchantChance}";
                UpdateLogEvent(logMessage);
            }
        }    

        private void SaveItemAccessory(Item item)
        {
            Item dbItemAccessory = itemRepository.SaveItemAccessory(item);
            UpdateEnchanceLevel(dbItemAccessory);
        }

        private void RemoveItemAccessory(Item item)
        {
            Item dbItemAccessory = itemRepository.RemoveItemAccessory(item);
            UpdateEnchanceLevel(dbItemAccessory);
        }
        private void UpdateLogEvent(string logMessage)
        {
            LogEvent?.Invoke(this, logMessage);
        }

        public void UpdateEnchanceLevel(Item item)
        {
            EnchanceLevel?.Invoke(this, item.EnchanceLevel);
        }

        internal void ResetCount()
        {
            ItemCount = 0;
        }
    }
}
