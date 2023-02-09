using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Repository;
using L2_Сhance.Main.Service.Item;
using L2_Сhance.Main.Service;
using L2_Сhance.Main.Repository.Item;

namespace L2_Сhance.Main.Factory
{
    internal class ServiceFactory
    {
        public static IAbstractService GetServiceByItemType(ItemType selectedItemType)
        {
            switch (selectedItemType)
            {
                case ItemType.ACCESSORY:
                    return new AccessoryService(new AccessoryRepository());
                case ItemType.ARMOR:
                    return new ArmorService(new ArmorRepository());
                case ItemType.WEAPON:
                    return new WeaponService(new WeaponRepository());
                case ItemType.VENIR:
                    return new VenirService(new VenirRepository());
                default:
                    return null;
            }
        }
    }
}
