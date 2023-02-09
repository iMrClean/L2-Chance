using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Model.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Сhance.Main.Repository.Item
{
    internal class VenirRepository
    {
        private static Venir dbItem = new Venir()
        {
            EnchanceLevel = 0,
            ItemType = ItemType.VENIR
        };

        public Venir GetItem()
        {
            return dbItem;
        }

        public Venir SaveItem(Venir venir)
        {
            dbItem = new Venir()
            {
                EnchanceLevel = ++venir.EnchanceLevel,
                ItemType = ItemType.WEAPON
            };

            return dbItem;
        }

        public Venir DeleteItem()
        {
            dbItem = new Venir()
            {
                EnchanceLevel = 0,
                ItemType = ItemType.WEAPON
            };

            return dbItem;
        }
    }
}
