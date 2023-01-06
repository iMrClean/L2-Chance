using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;

namespace L2_Сhance.Main.Repository
{
    internal class AccessoryRepository
    {

        private static Accessory dbItem = new Accessory()
        {
            EnchanceLevel = 0,
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
                ItemType = ItemType.ACCESSORY
            };
            
            return dbItem;
        }

        public Accessory DeleteItem()
        {
            dbItem = new Accessory()
            {
                EnchanceLevel = 0,
                ItemType = ItemType.ACCESSORY
            };

            return dbItem;
        }
    }
}
