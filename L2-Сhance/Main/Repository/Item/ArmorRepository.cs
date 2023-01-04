using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;

namespace L2_Сhance.Main.Repository
{
    internal class ArmorRepository
    {
        private static Armor dbItem = new Armor()
        {
            EnchanceLevel = 0,
            EnchantChance = 100,
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
                EnchantChance = armor.EnchantChance = dbItem.GetCurrentChance(),
                ItemType = ItemType.ARMOR
            };

            return dbItem;
        }

        public Armor RemoveItem()
        {
            dbItem = new Armor()
            {
                EnchanceLevel = 0,
                EnchantChance = 100,
                ItemType = ItemType.ARMOR
            };

            return dbItem;
        }
    }
}
