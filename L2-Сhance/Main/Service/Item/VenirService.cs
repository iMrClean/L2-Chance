using L2_Сhance.Main.Model;
using L2_Сhance.Main.Model.Item;
using L2_Сhance.Main.Repository;
using L2_Сhance.Main.Repository.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Сhance.Main.Service.Item
{
    internal class VenirService : AbstractService<Venir>
    {
        private readonly VenirRepository venirRepository;

        public VenirService(VenirRepository venirRepository)
        {
            this.venirRepository = venirRepository;
        }

        public override Venir GetItem()
        {
            return venirRepository.GetItem();
        }

        public override Venir SaveItem(Venir armor)
        {
            return venirRepository.SaveItem(armor);
        }
        public override Venir DeleteItem()
        {
            return venirRepository.DeleteItem();
        }
    }
}
