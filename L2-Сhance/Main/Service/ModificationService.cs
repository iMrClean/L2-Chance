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
                    DoMagicWeapon(item);
                    break;
                case ItemType.ARMOR:
                    DoMagicArmor(item);
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
                itemRepository.SaveItemAccessory(item);
                return;
            }

            int resultValue = random.Next(0, 101);

            if (resultValue <= currentEnchantChance)
            {
                string logMessage = $"[Успешно] Текущее значение модификации: {currentEnchanceLevel}, шанс: {resultValue}, шанс заточки: {currentEnchantChance}";
                UpdateLogEvent(logMessage);
                itemRepository.SaveItemAccessory(item);
            }
            else
            {
                ++ItemCount;
                string logMessage = $"[Неуспешно] Шанс: {resultValue}, шанс заточки: {item.EnchantChance}";
                UpdateLogEvent(logMessage);
                itemRepository.RemoveItemAccessory(item);
            }
        }

        internal void DoMagicWeapon(Item item)
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
                itemRepository.SaveItemWeapon(item);
            }
            else
            {
                ++ItemCount;
                string logMessage = $"[Неуспешно] Шанс: {resultValue}, шанс заточки: {item.EnchantChance}";
                UpdateLogEvent(logMessage);
                itemRepository.RemoveItemWeapon(item);
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

        private void UpdateLogEvent(string logMessage)
        {
            LogEvent?.Invoke(this, logMessage);
        }
    }
}
