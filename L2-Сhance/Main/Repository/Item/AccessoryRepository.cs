using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;

namespace L2_Сhance.Main.Repository
{
    internal class AccessoryRepository
    {
        private static Accessory dbItem = new Accessory()
        {
            EnchanceLevel = 0,
            EnchantChance = 100,
            ItemType = ItemType.ACCESSORY
        };

        public Accessory GetItem()
        {
            return dbItem;
        }

        public Accessory SaveItem(Accessory accessory)
        {
            dbItem = new Accessory()
            {
                EnchanceLevel = ++accessory.EnchanceLevel,
                EnchantChance = accessory.EnchantChance = dbItem.GetCurrentChance(),
                ItemType = ItemType.ACCESSORY
            };
            
            return dbItem;
        }

        public Accessory RemoveItem()
        {
            dbItem = new Accessory()
            {
                EnchanceLevel = 0,
                EnchantChance = 100,
                ItemType = ItemType.ACCESSORY
            };

            return dbItem;
        }
    }
}
