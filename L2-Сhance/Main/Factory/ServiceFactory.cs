using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Service;
using System;

namespace L2_Сhance.Main.Factory
{
    internal abstract class ServiceFactory
    { 
        public static ServiceFactory CreateItemServiceFactory(ItemType itemType)
        {
            switch (itemType)
            {
                case ItemType.UNDEFINED:
                    return null;
                case ItemType.ACCESSORY:
                    return new AccessoryService();
                case ItemType.ARMOR:
                    return new ArmorService();
                case ItemType.WEAPON:
                    return new WeaponService();
                default:
                    throw new NotImplementedException();
            }
        }

        internal static IAbstractService CreateItemFactory(ItemType itemType)
        {
            switch (itemType)
            {
                case ItemType.UNDEFINED:
                    throw new Exception("Не выбран тип");
                case ItemType.ACCESSORY:
                    return new AccessoryService();
                case ItemType.ARMOR:
                    return new ArmorService();
                case ItemType.WEAPON:
                    return new WeaponService();
                default:
                    throw new NotImplementedException();
            }
        }

        public abstract void DoMagic();

    }
}
