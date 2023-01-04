using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Factory;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class AccessoryService : AbstractService<Accessory>
    {
        private readonly AccessoryRepository accessoryRepository;

        public AccessoryService()
        {
            this.accessoryRepository = new AccessoryRepository();
        }

        public override void DeleteItem(Accessory model)
        {
            throw new NotImplementedException();
        }

        public override void GetItem()
        {
            throw new NotImplementedException();
        }

        public override void SaveItem(Accessory model)
        {
            throw new NotImplementedException();
        }
    }
}
