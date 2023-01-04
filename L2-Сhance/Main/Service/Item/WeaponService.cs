using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Factory;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class WeaponService : AbstractService<Weapon>
    {
        private readonly WeaponRepository weaponRepository;

        public WeaponService() 
        {
            this.weaponRepository = new WeaponRepository();
        }

        public override void DeleteItem(Weapon model)
        {
            throw new NotImplementedException();
        }

        public override void GetItem()
        {
            throw new NotImplementedException();
        }

        public override void SaveItem(Weapon model)
        {
            throw new NotImplementedException();
        }
    }
}
