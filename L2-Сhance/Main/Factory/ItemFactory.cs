using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using L2_Сhance.Main.Service;
using System;
using System.Windows.Media;

namespace L2_Сhance.Main
{
    internal class ItemFactory
    {
        private readonly AccessoryService accessoryService;

        private readonly WeaponService weaponService;

        private readonly ArmorService armorService;

        public ItemFactory()
        {
            this.accessoryService = new AccessoryService(new AccessoryRepository());
            this.weaponService = new WeaponService(new WeaponRepository());
            this.armorService = new ArmorService(new ArmorRepository());
        }

        public Item GetItemByType(ItemType itemType)
        {
            Item item = null;

            if (itemType == ItemType.UNDEFINED)
            {
                item = null;
            }
            else if (itemType == ItemType.ACCESSORY)
            {
                item = accessoryService.GetItem();
            }
            else if (itemType == ItemType.WEAPON)
            {
                item = weaponService.GetItem();
            }
            else if (itemType == ItemType.ARMOR)
            {
                item = armorService.GetItem();
            }
            return item;
        }
    }
}
