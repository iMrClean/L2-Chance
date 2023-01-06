using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class AccessoryService
    {

        private readonly AccessoryRepository accessoryRepository;

        public AccessoryService(AccessoryRepository accessoryRepository)
        {
            this.accessoryRepository = accessoryRepository;
        }

        public Accessory GetItem()
        {
            return accessoryRepository.GetItem();
        }

        public Accessory SaveItem(Accessory accessory)
        {
            return accessoryRepository.SaveItem(accessory);
        }
        public Accessory DeleteItem()
        {
            return accessoryRepository.DeleteItem();
        }
    }
}
