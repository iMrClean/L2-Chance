using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Сhance.Main.Repository
{
    internal class AccessoryRepository
    {
        private static Accessory dbItemAccessory = new Accessory()
        {
            EnchanceLevel = 0,
            EnchantChance = 100,
            ItemType = ItemType.ACCESSORY
        };

        public Item GetItemAccessory()
        {
            return dbItemAccessory;
        }

        public Item SaveItemAccessory(Accessory item)
        {
            dbItemAccessory.EnchanceLevel = ++item.EnchanceLevel;
            dbItemAccessory.EnchantChance = item.EnchantChance = dbItemAccessory.GetCurrentChance();
            
            return dbItemAccessory;
        }

        public Item RemoveItemAccessory()
        {
            dbItemAccessory = new Accessory()
            {
                EnchanceLevel = 0,
                EnchantChance = 100,
                ItemType = ItemType.ACCESSORY
            };

            return dbItemAccessory;
        }
    }
}
