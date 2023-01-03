using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;
using System.Windows.Forms;

namespace L2_Сhance.Main.Service
{
    internal abstract class AbstractService
    {
        public int ItemCount { get; private set; }

        public ItemType ItemType { get; private set; }

        internal void ResetCount()
        {
            ItemCount = 0;
        }

        internal abstract void DoMagic(AbstractItem item);

        internal abstract void SaveItem(AbstractItem item);

        internal abstract void RemoveItem(AbstractItem item);

        internal abstract ItemType GetItemType();

    }
}
