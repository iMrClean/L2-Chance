using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using System;
using System.Windows.Forms;

namespace L2_Сhance.Main.Service
{
    internal class ModificationService
    {
        private static readonly Random random = new Random();

        private readonly ItemRepository itemRepository;

        public event EventHandler<string> LogEvent;

        public int ItemCount { get; private set; }

        public ModificationService(ItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        internal void Process(Item item)
        {
            switch (item.ItemType)
            {
                case ItemType.ACCESSORY:
                    DoMagicAccessory(item);
                    break;
                case ItemType.WEAPON:
                    break;
                case ItemType.ARMOR:
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        internal void DoMagicAccessory(Item item)
        {
            int currentEnchanceLevel = item.EnchanceLevel;
            int currentEnchantChance = item.EnchantChance;

            if (currentEnchanceLevel < 1)
            {
                string logMessage = $"[Успешно] Текущее значение модификации: {currentEnchanceLevel}, модифицировано: {++currentEnchanceLevel}";
                UpdateLogEvent(logMessage);
                itemRepository.SaveItem(item);
                return;
            }

            int resultValue = random.Next(0, 101);

            if (resultValue <= currentEnchantChance)
            {
                string logMessage = $"[Успешно] Текущее значение модификации: {currentEnchanceLevel}, шанс: {resultValue}, шанс заточки: {currentEnchantChance}";
                UpdateLogEvent(logMessage);                
                itemRepository.SaveItem(item);
            }
            else
            {
                string logMessage = $"[Неуспешно] Шанс: {resultValue}, шанс заточки: {item.EnchantChance}";
                UpdateLogEvent(logMessage);
                itemRepository.RemoveItem(item);
                ++ItemCount;

            }
        }

        private void UpdateLogEvent(string logMessage)
        {
            LogEvent?.Invoke(this, logMessage);
        }
    }
}
