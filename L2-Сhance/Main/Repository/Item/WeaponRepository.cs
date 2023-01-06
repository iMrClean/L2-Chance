using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;

namespace L2_Сhance.Main.Repository
{
    internal class WeaponRepository
    {
        private static Weapon dbItem = new Weapon()
        {
            EnchanceLevel = 0,
            EnchantChance = 100,
            ItemType = ItemType.WEAPON
        };

        public Weapon GetItem()
        {
            return dbItem;
        }

        public Weapon SaveItem(Weapon weapon)
        {
            dbItem = new Weapon()
            {
                EnchanceLevel = ++weapon.EnchanceLevel,
                EnchantChance = weapon.EnchantChance = dbItem.GetCurrentChance(),
                ItemType = ItemType.WEAPON
            };

            return dbItem;
        }

        public Weapon DeleteItem()
        {
            dbItem = new Weapon()
            {
                EnchanceLevel = 0,
                EnchantChance = 100,
                ItemType = ItemType.WEAPON
            };

            return dbItem;
        }
    }
}
