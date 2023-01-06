using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class ArmorService : AbstractService<Armor>
    {

        private readonly ArmorRepository armorRepository;

        public ArmorService(ArmorRepository armorRepository)
        {
            this.armorRepository = armorRepository;
        }

        public override Armor GetItem()
        {
            return armorRepository.GetItem();
        }

        public override Armor SaveItem(Armor armor)
        {
            return armorRepository.SaveItem(armor);
        }
        public override Armor DeleteItem()
        {
            return armorRepository.DeleteItem();
        }
    }
}
