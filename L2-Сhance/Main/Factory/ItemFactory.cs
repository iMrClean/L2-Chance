using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using L2_Сhance.Main.Service;
using System;

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

            switch (itemType)
            {
                case ItemType.UNDEFINED:
                    item = null;
                    break;
                case ItemType.ACCESSORY:
                    item = accessoryService.GetItem();
                    break;
                case ItemType.WEAPON:
                    item = weaponService.GetItem();
                    break;
                case ItemType.ARMOR:
                    item = armorService.GetItem();
                    break;
            }

            return item;
        }

        public Item SaveItem(Item item)
        {
            ItemType itemType = item.ItemType;

            switch (itemType)
            {
                case ItemType.UNDEFINED:
                    throw new Exception("Ошибка при сохранении, тип item не определен");
                case ItemType.ACCESSORY:
                    item = accessoryService.SaveItem((Accessory)item);
                    break;
                case ItemType.WEAPON:
                    item = weaponService.SaveItem((Weapon)item);
                    break;
                case ItemType.ARMOR:
                    item = armorService.SaveItem((Armor)item);
                    break;
            }


            return item;
        }

        public Item DeleteItem(Item item)
        {
            ItemType itemType = item.ItemType;

            switch (itemType)
            {
                case ItemType.UNDEFINED:
                    throw new Exception("Ошибка при удалении, тип item не определен");
                case ItemType.ACCESSORY:
                    item = accessoryService.DeleteItem();
                    break;
                case ItemType.WEAPON:
                    item = weaponService.DeleteItem();
                    break;
                case ItemType.ARMOR:
                    item = armorService.DeleteItem();
                    break;
            }

            return item;
        }
    }
}
