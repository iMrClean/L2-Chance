using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Factory;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class WeaponService : ItemServiceFactory
    {
        private readonly WeaponRepository weaponRepository;

        public WeaponService() 
        {
            this.weaponRepository = new WeaponRepository();
        }

        public override AbstractItem GetItem()
        {
            return weaponRepository.GetItem();
        }

        public override AbstractItem SaveItem()
        {
            throw new NotImplementedException();
        }
        public override AbstractItem DeleteItem()
        {
            throw new NotImplementedException();
        }
    }
}
