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
/*
        public Item GetItem(ItemType itemType)
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
*/
        public T GetItemByType<T>(ItemType itemType) where T : Item
        {
            T item = default;

            if (itemType == ItemType.UNDEFINED)
            {
                item = default;
            }
            else if (itemType == ItemType.ACCESSORY)
            {
                item = (T)Convert.ChangeType(accessoryService.GetItem(), typeof(Accessory));
            }
            else if (itemType == ItemType.WEAPON)
            {
                item = (T)Convert.ChangeType(weaponService.GetItem(), typeof(Weapon));
            }
            else if (itemType == ItemType.ARMOR)
            {
                item = (T)Convert.ChangeType(armorService.GetItem(), typeof(Armor));
            }

            return item;
        }

        public T GetChildItemByParent<T>(Item item) where T : Item
        {
            if (item == null) 
                return default;

            var child = GetChild(item);

            var result = (child as T) ?? GetChildItemByParent<T>(child);

            if (result != null)
                return result;
            else
                return default;
        }

        private Item GetChild(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
