using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class WeaponService
    {

        private readonly WeaponRepository weaponRepository;

        public WeaponService(WeaponRepository weaponRepository) 
        {
            this.weaponRepository = weaponRepository;
        }

        public Weapon GetItem()
        {
            return weaponRepository.GetItem();
        }

        public Weapon SaveItem(Weapon weapon)
        {
            return weaponRepository.SaveItem(weapon);
        }
        public Weapon DeleteItem()
        {
            return weaponRepository.DeleteItem();
        }
    }
}
