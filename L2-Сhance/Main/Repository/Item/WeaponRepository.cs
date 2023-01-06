using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;

namespace L2_Сhance.Main.Repository
{
    internal class WeaponRepository
    {

        private static Weapon dbItem = new Weapon()
        {
            EnchanceLevel = 0,
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
                ItemType = ItemType.WEAPON
            };

            return dbItem;
        }

        public Weapon DeleteItem()
        {
            dbItem = new Weapon()
            {
                EnchanceLevel = 0,
                ItemType = ItemType.WEAPON
            };

            return dbItem;
        }
    }
}
