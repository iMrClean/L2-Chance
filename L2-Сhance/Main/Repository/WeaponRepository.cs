using L2_Сhance.Main.Model;

namespace L2_Сhance.Main.Repository
{
    internal class WeaponRepository
    {
        private static Weapon dbItem = new Weapon();

        public Weapon GetItem()
        {
            return dbItem;
        }

        public Weapon SaveItem(Weapon weapon)
        {
            return null;
        }

        public Weapon RemoveItem()
        {
            return null;
        }
    }
}
