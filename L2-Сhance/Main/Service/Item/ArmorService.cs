using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Factory;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class ArmorService : AbstractService<Armor>
    {
        private readonly ArmorRepository armorRepository;

        public ArmorService() 
        {
            this.armorRepository = new ArmorRepository();
        }

        public override void DeleteItem(Armor model)
        {
            throw new NotImplementedException();
        }

        public override void GetItem()
        {
            throw new NotImplementedException();
        }

        public override void SaveItem(Armor model)
        {
            throw new NotImplementedException();
        }
    }
}
