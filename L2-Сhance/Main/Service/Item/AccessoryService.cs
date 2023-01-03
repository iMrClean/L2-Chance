using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class AccessoryService : AbstractService
    {
        private readonly AccessoryRepository accessoryRepository;

        public AccessoryService()
        {
            accessoryRepository = new AccessoryRepository();
        }

        internal override void DoMagic(AbstractItem item)
        {
            Console.WriteLine("BBB");
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
            return ItemType.ACCESSORY;
        }
    }
}
