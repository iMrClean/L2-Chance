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
                MessageBox.Show($"Текущее значение модификации {currentEnchanceLevel}, Сейчас заточили на {++currentEnchanceLevel}");
                itemRepository.SaveItem(item);
                return;
            }
            
            int resultValue = random.Next(0, 101);

            if (resultValue <= currentEnchantChance)
            {
                MessageBox.Show($"Текущее значение модификации {currentEnchanceLevel}, ты попал в шанс {resultValue}, шанс заточки {currentEnchantChance}");
                itemRepository.SaveItem(item);
            }
            else
            {
                MessageBox.Show($"Просто соси, без пояснений, шанс рандома {resultValue}, шанс заточки {item.EnchantChance}");
                itemRepository.RemoveItem(item);
            }
        }

    }
}
