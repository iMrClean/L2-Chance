using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class WeaponService : AbstractService<Weapon>
    {

        private readonly WeaponRepository weaponRepository;

        public WeaponService(WeaponRepository weaponRepository) 
        {
            this.weaponRepository = weaponRepository;
        }

        public override Weapon GetItem()
        {
            return weaponRepository.GetItem();
        }

        public override Weapon SaveItem(Weapon weapon)
        {
            return weaponRepository.SaveItem(weapon);
        }
        public override Weapon DeleteItem()
        {
            return weaponRepository.DeleteItem();
        }
    }
}
