using L2_Сhance.Main.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Сhance.Main
{
    internal class ItemRepository
    {
        private static Item dbItem = new Item()
        {
            EnchanceLevel = 0,
            EnchantChance = 100
        };

        public event EventHandler<int> EnchanceLevel;

        public Item GetItem()
        {
            return dbItem;
        }

        public void SaveItem(Item item)
        {
            dbItem.EnchanceLevel = ++item.EnchanceLevel;
            int value = item.EnchantChance = GetCurrentChance(item.EnchanceLevel);
            dbItem.EnchantChance = value;
            UpdateEnchanceLevel();
        }

        public void RemoveItem(Item item)
        {
            dbItem = new Item()
            {
                EnchanceLevel = 0,
                EnchantChance = 100
            };
            UpdateEnchanceLevel();
        }

        public int GetCurrentChance(int enchanceLevel)
        {
            int result = 100;

            if (enchanceLevel == 1)
            {
                result -= 50;
            }
            else if (enchanceLevel == 2)
            {
                result -= 60;
            }
            else if (enchanceLevel == 3)
            {
                result -= 70;
            }
            else if (enchanceLevel == 4)
            {
                result -= 50;
            }
            else if (enchanceLevel == 5)
            {
                result -= 92;
            }
            return result;
        }

        private void UpdateEnchanceLevel()
        {
            EnchanceLevel?.Invoke(this, dbItem.EnchanceLevel);
        }
    }
}
