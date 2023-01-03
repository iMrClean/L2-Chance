using L2_Сhance.Main.Enum;
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
        private static Item dbItemAccessory = new Item()
        {
            EnchanceLevel = 0,
            EnchantChance = 100,
            ItemType = ItemType.ACCESSORY
        };

        private static Item dbItemWeapon = new Item()
        {
            EnchanceLevel = 0,
            EnchantChance = 100,
            ItemType = ItemType.WEAPON
        };

        private static Item dbItemArmor = new Item()
        {
            EnchanceLevel = 0,
            EnchantChance = 100,
            ItemType = ItemType.ARMOR
        };

        public Item GetItemAccessory()
        {
            return dbItemAccessory;
        }

        public Item GetItemWeapon()
        {
            return dbItemWeapon;

        }

        public Item GetItemArmor()
        {
            return dbItemArmor;
        }

        public Item SaveItemAccessory(Item item)
        {
            dbItemAccessory.EnchanceLevel = ++item.EnchanceLevel;
            int value = item.EnchantChance = GetCurrentChanceAccessory(item.EnchanceLevel);
            dbItemAccessory.EnchantChance = value;
            return dbItemAccessory;
        }

        public Item RemoveItemAccessory(Item item)
        {
            dbItemAccessory = new Item()
            {
                EnchanceLevel = 0,
                EnchantChance = 100,
                ItemType = ItemType.ACCESSORY
            };
            return dbItemAccessory;
        }

        public Item SaveItemWeapon(Item item)
        {
            dbItemWeapon.EnchanceLevel = ++item.EnchanceLevel;
            int value = item.EnchantChance = GetCurrentChanceWeapon(item.EnchanceLevel);
            dbItemWeapon.EnchantChance = value;
            return dbItemWeapon;
        }

        public Item RemoveItemWeapon(Item item)
        {
            dbItemWeapon = new Item()
            {
                EnchanceLevel = 0,
                EnchantChance = 100,
                ItemType = ItemType.WEAPON
            };
            return dbItemWeapon;
        }

        public Item SaveItemArmor(Item item)
        {
            dbItemArmor.EnchanceLevel = ++item.EnchanceLevel;
            int value = item.EnchantChance = GetCurrentChanceArmor(item.EnchanceLevel);
            dbItemArmor.EnchantChance = value;
            return dbItemArmor;
        }

        public Item RemoveItemArmor(Item item)
        {
            dbItemArmor = new Item()
            {
                EnchanceLevel = 0,
                EnchantChance = 100,
                ItemType = ItemType.ARMOR
            };
            return dbItemArmor;
        }

        private int GetCurrentChanceAccessory(int enchanceLevel)
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

        private int GetCurrentChanceWeapon(int enchanceLevel)
        {
            int result = 100;

            if (enchanceLevel == 4)
            {
                result -= 70;
            }
            else if (enchanceLevel == 5)
            {
                result -= 75;
            }
            else if (enchanceLevel == 6)
            {
                result -= 80;
            }
            else if (enchanceLevel == 7)
            {
                result -= 85;
            }
            else if (enchanceLevel == 8)
            {
                result -= 90;
            }
            else if (enchanceLevel == 9)
            {
                result -= 95;
            }
            return result;
        }

        private int GetCurrentChanceArmor(int enchanceLevel)
        {
            int result = 100;

            if (enchanceLevel == 5)
            {
                result -= 70;
            }
            else if (enchanceLevel == 6)
            {
                result -= 75;
            }
            else if (enchanceLevel == 7)
            {
                result -= 80;
            }
            else if (enchanceLevel == 8)
            {
                result -= 85;
            }
            else if (enchanceLevel == 9)
            {
                result -= 90;
            }
            else if (enchanceLevel == 10)
            {
                result -= 95;
            }
            return result;
        }
    }
}
