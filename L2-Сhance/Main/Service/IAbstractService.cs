using L2_Сhance.Main.Model;

namespace L2_Сhance.Main.Service.Item
{
    internal interface IAbstractService
    {
        AbstractItem GetItem();

        AbstractItem SaveItem(AbstractItem item);

        AbstractItem DeleteItem();

        bool DoMagic(AbstractItem item);

    }
}
