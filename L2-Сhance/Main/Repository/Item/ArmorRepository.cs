using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;

namespace L2_Сhance.Main.Repository
{
    internal class ArmorRepository
    {

        private static Armor dbItem = new Armor()
        {
            EnchanceLevel = 0,
            ItemType = ItemType.ARMOR
        };

        public Armor GetItem()
        {
            return dbItem;
        }

        public Armor SaveItem(Armor armor)
        {
            dbItem = new Armor()
            {
                EnchanceLevel = ++armor.EnchanceLevel,
                ItemType = ItemType.ARMOR
            };

            return dbItem;
        }

        public Armor DeleteItem()
        {
            dbItem = new Armor()
            {
                EnchanceLevel = 0,
                ItemType = ItemType.ARMOR
            };

            return dbItem;
        }
    }
}
