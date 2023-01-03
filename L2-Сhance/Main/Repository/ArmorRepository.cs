using L2_Сhance.Main.Model;

namespace L2_Сhance.Main.Repository
{
    internal class ArmorRepository
    {
        private static Armor dbItem = new Armor();

        public Armor GetItem()
        {
            return dbItem;
        }

        public Armor SaveItem(Armor armor)
        {
            return null;
        }

        public Armor RemoveItem()
        {
            return null;
        }
    }
}
