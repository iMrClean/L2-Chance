using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Factory;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class AccessoryService : ItemServiceFactory
    {
        private readonly AccessoryRepository accessoryRepository;

        public AccessoryService()
        {
            this.accessoryRepository = new AccessoryRepository();
        }

        public override ItemFactory GetItem()
        {
            return accessoryRepository.GetItem();
        }

        public override ItemFactory SaveItem()
        {
            throw new NotImplementedException();
        }

        public override ItemFactory DeleteItem()
        {
            throw new NotImplementedException();
        }
    }
}
