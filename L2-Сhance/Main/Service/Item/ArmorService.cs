using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Factory;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class ArmorService : ItemServiceFactory
    {
        private readonly ArmorRepository armorRepository;

        public ArmorService() 
        {
            this.armorRepository = new ArmorRepository();
        }

        public override AbstractItem GetItem()
        {
            return armorRepository.GetItem();
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
