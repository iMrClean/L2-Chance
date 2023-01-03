using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class WeaponService : AbstractService
    {
        private readonly WeaponRepository weaponRepository;

        public WeaponService() 
        {
            weaponRepository = new WeaponRepository();
        }

        internal override void DoMagic(AbstractItem item)
        {
            Console.Beep();
        }

        internal override void RemoveItem(AbstractItem item)
        {
            throw new NotImplementedException();
        }

        internal override void SaveItem(AbstractItem item)
        {
            throw new NotImplementedException();
        }

        internal override ItemType GetItemType()
        {
            return ItemType.WEAPON;
        }
    }
}
