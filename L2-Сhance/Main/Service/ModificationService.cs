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

        public event EventHandler<int> EnchanceLevel;

        public int ItemCount { get; private set; }
        
        public ModificationService()
        {
            itemRepository = new ItemRepository();
        }

        internal Item GetItemAccessory()
        {
            return itemRepository.GetItemAccessory();
        }

        internal Item GetItemWeapon()
        {
            return itemRepository.GetItemWeapon();
        }

        internal Item GetItemArmor()
        {
            return itemRepository.GetItemArmor();
        }

        internal void DoMagicAccessory(Item item)
        {
            int currentEnchanceLevel = item.EnchanceLevel;
            int currentEnchantChance = item.EnchantChance;

            if (currentEnchanceLevel < 1)
            {
                SaveItemAccessory(item);
                string logMessage = $"[Успешно] Текущее значение модификации: {currentEnchanceLevel}, модифицировано: {++currentEnchanceLevel}";
                UpdateLogEvent(logMessage);
                return;
            }

            int resultValue = random.Next(0, 101);

            if (resultValue <= currentEnchantChance)
            {
                SaveItemAccessory(item);
                string logMessage = $"[Успешно] Текущее значение модификации: {currentEnchanceLevel}, шанс: {resultValue}, шанс заточки: {currentEnchantChance}";
                UpdateLogEvent(logMessage);
            }
            else
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
        internal void DoMagicWeapon(Item item)
        {
            int currentEnchanceLevel = item.EnchanceLevel;
            int currentEnchantChance = item.EnchantChance;

            if (currentEnchanceLevel < 4)
            {
                itemRepository.SaveItemWeapon(item);
                string logMessage = $"[Успешно] Текущее значение модификации: {currentEnchanceLevel}, модифицировано: {++currentEnchanceLevel}";
                UpdateLogEvent(logMessage);
                return;
            }

            int resultValue = random.Next(0, 101);

            if (resultValue <= currentEnchantChance)
            {
                itemRepository.SaveItemWeapon(item);
                string logMessage = $"[Успешно] Текущее значение модификации: {currentEnchanceLevel}, шанс: {resultValue}, шанс заточки: {currentEnchantChance}";
                UpdateLogEvent(logMessage);
            }
            else
            {
                ++ItemCount;
                itemRepository.RemoveItemWeapon(item);
                string logMessage = $"[Неуспешно] Шанс: {resultValue}, шанс заточки: {item.EnchantChance}";
                UpdateLogEvent(logMessage);
            }
        }

        internal void DoMagicArmor(Item item)
        {
            int currentEnchanceLevel = item.EnchanceLevel;
            int currentEnchantChance = item.EnchantChance;

            if (currentEnchanceLevel < 4)
            {
                string logMessage = $"[Успешно] Текущее значение модификации: {currentEnchanceLevel}, модифицировано: {++currentEnchanceLevel}";
                UpdateLogEvent(logMessage);
                itemRepository.SaveItemWeapon(item);
                return;
            }

            int resultValue = random.Next(0, 101);

            if (resultValue <= currentEnchantChance)
            {
                string logMessage = $"[Успешно] Текущее значение модификации: {currentEnchanceLevel}, шанс: {resultValue}, шанс заточки: {currentEnchantChance}";
                UpdateLogEvent(logMessage);
                itemRepository.SaveItemArmor(item);
            }
            else
            {
                ++ItemCount;
                string logMessage = $"[Неуспешно] Шанс: {resultValue}, шанс заточки: {item.EnchantChance}";
                UpdateLogEvent(logMessage);
                itemRepository.RemoveItemArmor(item);
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
