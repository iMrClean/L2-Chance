using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;

namespace L2_Сhance.Main.Service
{
    internal class ArmorService
    {
        private readonly ArmorRepository armorRepository;

        public ArmorService(ArmorRepository armorRepository) 
        {
            this.armorRepository = armorRepository;
        }

        public Armor GetItem()
        {
            return armorRepository.GetItem();
        }

        public Armor SaveItem(Armor armor)
        {
            return armorRepository.SaveItem(armor);
        }
        public Armor DeleteItem()
        {
            return armorRepository.RemoveItem();
        }
    }
}
