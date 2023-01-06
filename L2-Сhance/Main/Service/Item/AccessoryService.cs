using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class AccessoryService : AbstractService<Accessory>
    {

        private readonly AccessoryRepository accessoryRepository;

        public AccessoryService(AccessoryRepository accessoryRepository)
        {
            this.accessoryRepository = accessoryRepository;
        }

        public override Accessory GetItem()
        {
            return accessoryRepository.GetItem();
        }

        public override Accessory SaveItem(Accessory accessory)
        {
            return accessoryRepository.SaveItem(accessory);
        }
        public override Accessory DeleteItem()
        {
            return accessoryRepository.DeleteItem();
        }
    }
}
